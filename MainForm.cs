using Microsoft.EntityFrameworkCore;
using numi.src.domain.Data;
using numi.src.domain.Models;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Runtime.InteropServices;
using ZXing;
using ZXing.Rendering;
using ZXing.Windows.Compatibility;

namespace numi;
public partial class MainForm : Form
{
    private AppDbContext? _dbContext;
    private Bitmap _bitmap;
    private Product _currentProduct;
    public MainForm()
    {
        InitializeComponent();
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        _dbContext = new AppDbContext();

        //_dbContext.Database.EnsureDeleted();
        _dbContext.Database.EnsureCreated();
        _dbContext.Categories.Load();
        this.categoryBindingSource.DataSource = _dbContext.Categories.Local.ToBindingList();
        UpdateDataGridViewProducts();
    }

    protected override void OnClosed(EventArgs e)
    {
        base.OnClosed(e);
        _dbContext?.Dispose();
        _dbContext = null;
    }

    private void MainForm_Load(object sender, EventArgs e)
    {


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
            this._dbContext?.Entry(category).Collection(e => e.Products).Load();
        }
    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
        this._dbContext?.SaveChanges();
        comboBoxCategories.Refresh();
        dataGridViewProducts.Refresh();
    }

    private void dataGridViewProducts_SelectionChanged(object sender, EventArgs e)
    {
        if (this._dbContext is null) return;
        var product = dataGridViewProducts.CurrentRow?.DataBoundItem;

        if (product is Product currentProduct)
        {
            _currentProduct = currentProduct;
            _bitmap = GetBitmap();
            pictureBoxBarcode.Image = _bitmap;
        }
    }

    private void buttonPrint_Click(object sender, EventArgs e)
    {
        PrintDocument printDocument = new()
        {
            DocumentName = _currentProduct.ProductId + " " + _currentProduct.Name + " " + _currentProduct.Dimension
        };

        printDocument.PrintPage += (sender, ev) =>
        {
            ev.PageSettings.PaperSize = printDocument.DefaultPageSettings.PaperSize;
            ev.Graphics?.DrawImage(_bitmap, 0, 0);
        };
        printDocument.Print();
    }

    private Bitmap GetBitmap()
    {
        BarcodeWriter writer = new()
        {
            Format = BarcodeFormat.CODE_128,
            //Renderer = new BitmapRenderer(),
            Options = new()
            {
                Width = 100,
                Height = 100,
                Margin = 20,
                NoPadding = true,
                PureBarcode = false,
            }
        };
        var barcodeData = _currentProduct.ProductId + " " + _currentProduct.Name + "-" + _currentProduct.Dimension;
        writer.Write(barcodeData).Save(@"c:\users\msaleh\desktop\11.bmp", ImageFormat.Bmp);
        return writer.Write(barcodeData);
    }

}


/*
 * publishing self contained project
 * dotnet publish -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true
 * dotnet publish -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true -o "C:\PublishOutput"
 * 
 * 
 * Suggest print method
 * private void PrintBarcode()
{
    PrintDocument printDoc = new PrintDocument();
    printDoc.PrintPage += PrintPageHandler;
    printDoc.Print();
}

private void PrintPageHandler(object sender, PrintPageEventArgs e)
{
    // Assuming you have the barcode image in a Bitmap object
    Bitmap barcodeImage = (Bitmap)pictureBox1.Image;

    // Calculate the scaling factor to fit the barcode image on the page
    float scaleFactor = Math.Min(e.MarginBounds.Width / barcodeImage.Width, e.MarginBounds.Height / barcodeImage.Height);

    // Create a scaled version of the barcode image
    Bitmap scaledImage = new Bitmap((int)(barcodeImage.Width * scaleFactor), (int)(barcodeImage.Height * scaleFactor));
    using (Graphics g = Graphics.FromImage(scaledImage))
    {
        g.DrawImage(barcodeImage, 0, 0, scaledImage.Width, scaledImage.Height);
    }

    // Draw the scaled image on the print page
    e.Graphics.DrawImage(scaledImage, e.MarginBounds.Left, e.MarginBounds.Top);
}
 * 
 */