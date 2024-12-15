using Microsoft.EntityFrameworkCore;
using numi.src.domain.Data;
using numi.src.domain.Models;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Text;
using ZXing;
using ZXing.Common;
using ZXing.Windows.Compatibility;

namespace numi;
public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        using var context = new AppDbContext(new DbContextOptions<AppDbContext>());

        //context.Database.EnsureDeleted();
        context.Database.EnsureCreated();
        context.Categories.Load();
        categoryBindingSource.DataSource = context.Categories.Local.ToBindingList();
        UpdateDataGridViewProducts();
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
            //this._appDBContext?.Entry(category).Collection(e => e.Products).Load();
            dataGridViewProducts.Rows.Clear();
            using var context = new AppDbContext(new DbContextOptions<AppDbContext>());
            context.Entry(category).Collection(e => e.Products).Load();
        }
    }

    private void dataGridViewProducts_SelectionChanged(object sender, EventArgs e)
    {
        var product = dataGridViewProducts.CurrentRow?.DataBoundItem;

        if (product is Product currentProduct)
        {
            DisplayBarcode(currentProduct);
            DisplayQrcode(currentProduct);

        }
    }

    private void DisplayBarcode(Product product)
    {
        if (product is null) return;

        string barcodeText = product.ProductId;// + "-" + product.Name + "-" + product.Dimension;
        var width = 350;
        var height = 80;

        Bitmap bitmap = GetBarcodeBitmap(barcodeText, BarcodeFormat.CODE_128, width, height);
        pictBxBarcode.SizeMode = PictureBoxSizeMode.CenterImage;
        pictBxBarcode.Image = bitmap;
    }

    private void DisplayQrcode(Product product)
    {
        if (product is null) return;

        string barcodeText = product.Name + "-" + product.Dimension;
        var width = pictBxBarcode.Width;
        var height = pictBxBarcode.Height;

        Bitmap bitmap = GetBarcodeBitmap(barcodeText, BarcodeFormat.QR_CODE, width, height);
        pictBxQrcode.SizeMode = PictureBoxSizeMode.CenterImage;
        pictBxQrcode.Image = bitmap;
    }

    private void buttonPrintBarcode_Click(object sender, EventArgs e)
    {
        if (dataGridViewProducts.CurrentRow?.DataBoundItem is not Product product) return;
        PrintBarcode(product, BarcodeFormat.CODE_128);
    }
    private void buttonPrintQrcode_Click(object sender, EventArgs e)
    {
        if (dataGridViewProducts.CurrentRow?.DataBoundItem is not Product product) return;
        PrintBarcode(product, BarcodeFormat.QR_CODE);
    }

    private void PrintBarcode(Product product, BarcodeFormat barcodeFromat)
    {
        string barcodeData = product.ProductId; // + " " + product.Name + " " + product.Dimension;
        PrintDocument printDocument = new()
        {
            DocumentName = barcodeData,
        };

        printDocument.PrintPage += (sender, ev) =>
        {
            string barcodeString = product.ProductId + "-" + product.Name + "-" + product.Dimension;
            Bitmap bitmap = GetBarcodeBitmap(barcodeString, barcodeFromat, 100, 350);
            ev.Graphics?.DrawImage(bitmap, 0, 20);
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

    private void buttonAdd_Click(object sender, EventArgs e)
    {
        var currentCategory = comboBoxCategories.SelectedItem as Category;
        if (currentCategory is null) return;

        var newProductForm = new NewProductForm
        {
            Category = currentCategory
        };

        var dialogResult = newProductForm.ShowDialog();
        if (dialogResult == DialogResult.Cancel) return;
        if (newProductForm.NewProduct is null) return;
        AddNewProduct(newProductForm.NewProduct);
    }

    private void AddNewProduct(Product newProduct)
    {
        using (var context = new AppDbContext(new DbContextOptions<AppDbContext>()))
        {
            context.Products.Add(newProduct);
            var entries = context.SaveChanges();
            if (entries == 0) return;
            Debug.WriteLine(entries);
            int newItemIdex = productsBindingSource.Add(newProduct);
            dataGridViewProducts.Rows[newItemIdex].Selected = true;
        }
    }

    private void ExportToCSVFile2(string path)
    {
        using var context = new AppDbContext(new DbContextOptions<AppDbContext>());
        var products = context.Products.ToList();

        StringBuilder stringBuilder = new();
        stringBuilder.AppendLine("ProductType,ProductFamily,ProductId,Description,Width,Lenght,Height");
        foreach (var product in products)
        {
            stringBuilder.Append("Mattress,");
            stringBuilder.Append($"{product.Name},");
            stringBuilder.Append($"{product.ProductId},");
            stringBuilder.Append($"{product.Description},");
            stringBuilder.Append($"{product.Width},");
            stringBuilder.Append($"{product.Length},");
            stringBuilder.Append($"{product.Height}");
            stringBuilder.AppendLine();
        }
        File.WriteAllText(path, stringBuilder.ToString());
    }

    private void ExportToCSVFile(string path)
    {
        using var context = new AppDbContext(new DbContextOptions<AppDbContext>());
        var products = context.Products.ToList();

        StringBuilder stringBuilder = new();
        stringBuilder.AppendLine("name;code;category;brand;cost;price;unit;stock_alert,note");
        foreach (var product in products)
        {
            stringBuilder.Append($"{product.Name};");
            stringBuilder.Append($"{product.ProductId};");
            stringBuilder.Append($"{product.Name};");
            stringBuilder.Append($"Numi;");
            stringBuilder.Append($"0;");
            stringBuilder.Append($"0;");
            stringBuilder.Append($"pc;");
            stringBuilder.Append($"0;");
            stringBuilder.Append($"{product.Description}");
            stringBuilder.AppendLine();
        }
        File.WriteAllText(path, stringBuilder.ToString());
    }


    private void buttonRemove(object sender, EventArgs e)
    {
        if (dataGridViewProducts.CurrentRow?.DataBoundItem is not Product product) return;
        int idx = dataGridViewProducts.CurrentRow.Index;

        using var context = new AppDbContext(new DbContextOptions<AppDbContext>());
        context.Products.Remove(product);
        context.SaveChanges();
        productsBindingSource.Remove(product);

        if (idx == 0) return;
        dataGridViewProducts.Rows[idx - 1].Selected = true;
    }

    private void buttonExportCSV_Click(object sender, EventArgs e)
    {
        string filter = "csv|*.csv";
        SaveFileDialog saveFileDialog = new()
        {
            Filter = filter,
            Title = "Save products as csv file"
        };

        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            ExportToCSVFile(saveFileDialog.FileName);
        }
    }

    protected override void OnClosing(CancelEventArgs e)
    {
        base.OnClosing(e);
        dataGridViewProducts.DataSource = null;
    }
}

/*
 * publishing self contained project
 * dotnet publish -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true
 * dotnet publish -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true -o "C:\PublishOutput"
 */