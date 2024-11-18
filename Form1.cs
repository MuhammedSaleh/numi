namespace numi;

using Microsoft.EntityFrameworkCore;
using numi.src.domain.Data;
using System;

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
    }

    protected override void OnClosed(EventArgs e)
    {
        base.OnClosed(e);
        _dbContext?.Dispose();
        _dbContext = null;
    }

}
