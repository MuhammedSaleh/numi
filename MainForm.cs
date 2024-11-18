namespace numi;

using Microsoft.EntityFrameworkCore;
using numi.src.domain.Data;
using numi.src.domain.Models;
using System;
using ZXing;

public partial class MainForm : Form
{
    private AppDbContext? _dbContext;
    public MainForm()
    {
        InitializeComponent();
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        _dbContext = new AppDbContext();

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
        var writer = new BarcodeWriter<Bitmap>()
        {
            Format = BarcodeFormat.CODE_128,
            Options = new ZXing.Common.EncodingOptions()
            {
                Height = 600,
                Width = 400,
                PureBarcode = false,
                Margin = 10
            }
        };
      //  var render = ZXing.Rendering.PixelData();
        var bitmap = writer.Write("Test Test");
        bitmap.Save(@"c:\users\muhammad\desktop\barcode1.png", System.Drawing.Imaging.ImageFormat.Png);
    }
}
