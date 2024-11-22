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

    private void buttonPrint_Click(object sender, EventArgs e)
    {
        //PrintLabel();

        PrintDocument printDocument = new();
        printDocument.DocumentName = _currentProduct.ProductId + " " + _currentProduct.Name + " " + _currentProduct.Dimension;
        printDocument.PrintPage += (sender, ev) =>
        {
            //printDocument.DefaultPageSettings = ev.PageSettings;
            ev.PageSettings.PaperSize = printDocument.DefaultPageSettings.PaperSize;
            //ev.PageSettings.PrinterSettings = printDocument.PrinterSettings;
           var bitmap = GetBitmap(ev);
            ev.Graphics?.DrawImage(bitmap, 50, 50, bitmap.Width + 150, bitmap.Height + 150);
            //ev.Graphics?.DrawImage(bitmap, 10, 10, ); // Todo: Important for sizing
        };
        printDocument.Print();
    }

    private Bitmap GetBitmap(PrintPageEventArgs ev)
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
                PureBarcode = true,
            }
        };
        Debug.WriteLine(ev.MarginBounds.Width);
        Debug.WriteLine(ev.MarginBounds.Height);
        var barcodeData = _currentProduct.ProductId + " " + _currentProduct.Name + "-" + _currentProduct.Dimension;
        writer.Write(barcodeData).Save(@"c:\users\muhammad\desktop\11.bmp");
        return writer.Write(barcodeData);
    }

    private Bitmap GenereateBitMap()
    {
        var writer = new BarcodeWriter<PixelData>
        {
            Format = BarcodeFormat.CODE_128,
            Renderer = new PixelDataRenderer(),
            Options = new ZXing.Common.EncodingOptions()
            {
                Width = 812 / 2,
                Height = 1218 / 2,
                PureBarcode = false,
                Margin = 10,
            },
        };
        //writer.Options.Hints[EncodeHintType.DISABLE_ECI] = false;

        var labelData = writer.Write(_currentProduct.ProductId + _currentProduct.Name);


        Bitmap bitmap = new(labelData.Width, labelData.Height);
        BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.WriteOnly, bitmap.PixelFormat);

        byte[] pixelValues = new byte[bitmapData.Stride * bitmapData.Height];

        // Copy pixel data from barcodeData.Pixels to pixelValues
        Array.Copy(labelData.Pixels, pixelValues, pixelValues.Length);

        // Copy pixelValues to bitmapData.Scan0
        Marshal.Copy(pixelValues, 0, bitmapData.Scan0, pixelValues.Length);

        bitmap.UnlockBits(bitmapData);
        _bitmap = bitmap;
        return bitmap;
    }

    private void PrintLabel()
    {
        PrintDocument document = new();
        document.PrintPage += (sender, e) =>
        {
            e.Graphics?.DrawImage(_bitmap, new Point(0, 0));
        };
        document.Print();
    }

    private void DispayLabel()
    {
        pictureBox1.Image = _bitmap;
    }

    private void dataGridViewProducts_SelectionChanged(object sender, EventArgs e)
    {
        if (this._dbContext is null) return;
        var product = dataGridViewProducts.CurrentRow?.DataBoundItem;

        if (product is Product currentProduct)
        {
            _currentProduct = currentProduct;
            GenereateBitMap();
            DispayLabel();
        }
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