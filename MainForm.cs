using Microsoft.EntityFrameworkCore;
using numi.src.domain.Data;
using numi.src.domain.Models;
using System.Diagnostics;
using System.Drawing.Printing;
using ZXing;
using ZXing.Common;
using ZXing.Windows.Compatibility;

namespace numi;
public partial class MainForm : Form
{
    private AppDbContext? _appDBContext;
    private Product? _currentProduct;
    public MainForm()
    {
        InitializeComponent();
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        _appDBContext = new AppDbContext();

        //_dbContext.Database.EnsureDeleted();
        _appDBContext.Database.EnsureCreated();
        _appDBContext.Categories.Load();
        this.categoryBindingSource.DataSource = _appDBContext.Categories.Local.ToBindingList();
        UpdateDataGridViewProducts();
    }

    protected override void OnClosed(EventArgs e)
    {
        base.OnClosed(e);
        _appDBContext?.Dispose();
        _appDBContext = null;
    }

    private void comboBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
    {
        UpdateDataGridViewProducts();
    }

    private void UpdateDataGridViewProducts()
    {
        var selectedItem = comboBoxCategories.SelectedItem;
        if (selectedItem is Category category)
        {
            this._appDBContext?.Entry(category).Collection(e => e.Products).Load();
        }
    }

    private void dataGridViewProducts_SelectionChanged(object sender, EventArgs e)
    {
        if (this._appDBContext is null) return;
        var product = dataGridViewProducts.CurrentRow?.DataBoundItem;

        if (product is Product currentProduct)
        {
            _currentProduct = currentProduct;
            DisplayBarcode();
            DisplayQrcode();

        }
    }

    private void DisplayBarcode()
    {
        if (_currentProduct is null) return;

        string barcodeText = _currentProduct.ProductId + "-" + _currentProduct.Name + "-" + _currentProduct.Dimension;
        var width = pictBxBarcode.Width * 90 / 100;
        var height = pictBxBarcode.Height * 90 / 100;

        Bitmap bitmap = GetBarcodeBitmap(barcodeText, BarcodeFormat.CODE_128, width, height);
        pictBxBarcode.SizeMode = PictureBoxSizeMode.CenterImage;
        pictBxBarcode.Image = bitmap;
    }

    private void DisplayQrcode()
    {
        if (_currentProduct is null) return;

        string barcodeText = _currentProduct.Name + "-" + _currentProduct.Dimension;
        var width = pictBxBarcode.Width;
        var height = pictBxBarcode.Height;

        Bitmap bitmap = GetBarcodeBitmap(barcodeText, BarcodeFormat.QR_CODE, width, height);
        pictBxQrcode.SizeMode = PictureBoxSizeMode.CenterImage;
        pictBxQrcode.Image = bitmap;
    }

    private void buttonPrintBarcode_Click(object sender, EventArgs e)
    {
        PrintBarcode(BarcodeFormat.CODE_128);
    }
    private void buttonPrintQrcode_Click(object sender, EventArgs e)
    {
        PrintBarcode(BarcodeFormat.QR_CODE);
    }

    private void PrintBarcode(BarcodeFormat barcodeFromat)
    {
        if (_currentProduct is null) return;

        string barcodeData = _currentProduct.ProductId + " " + _currentProduct.Name + " " + _currentProduct.Dimension;
        PrintDocument printDocument = new()
        {
            DocumentName = barcodeData,
        };

        printDocument.PrintPage += (sender, ev) =>
        {
            int printerResolution = ev.PageSettings.PrinterResolution.X;
            int width = ev.PageBounds.Width * printerResolution / 100;
            int height = ev.PageBounds.Height * printerResolution / 100;

            string barcodeString = _currentProduct.ProductId + "-" + _currentProduct.Name + "-" + _currentProduct.Dimension;
            Bitmap bitmap = GetBarcodeBitmap(barcodeString, barcodeFromat, width, height);
            ev.Graphics?.DrawImage(bitmap, 0, 0);
        };
        printDocument.Print();
    }


    private Bitmap GetBarcodeBitmap(string barcodText, BarcodeFormat format, int width, int height)
    {
        var writer = new BarcodeWriter()
        {
            Format = format,
            Options = new EncodingOptions
            {
                Width = width,
                Height = height,
                NoPadding = true,
            },
        };
        return writer.Write(barcodText);
    }

    private void button1_Click(object sender, EventArgs e)
    {
        var currentCategory = comboBoxCategories.SelectedItem as Category;
        if (currentCategory is null) return;

        var newProductForm = new NewProductForm
        {
            Category = currentCategory!.Name,
        };

        var dialogResult = newProductForm.ShowDialog();
        if (dialogResult == DialogResult.Cancel) return;
        if (newProductForm.NewProduct is null) return;
        AddNewProduct(newProductForm.NewProduct);
    }

    private void AddNewProduct(Product newProduct)
    {
        using var context = new AppDbContext();
        context.Products.Add(newProduct);
        context.SaveChanges();
    }
}

/*
 * publishing self contained project
 * dotnet publish -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true
 * dotnet publish -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true -o "C:\PublishOutput"
 */