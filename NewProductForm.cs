using numi.src.domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numi;

public partial class NewProductForm : Form
{
    private ErrorProvider errorProvider = new();

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Category Category { get; set; } = default!;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Product? NewProduct { get; set; }

    public NewProductForm()
    {
        InitializeComponent();
    }

    private void buttonCancel_Click(object sender, EventArgs e)
    {

    }

    private void buttonAdd_Click(object sender, EventArgs e)
    {
        if (!ValidateDimension()) return;
        // Todo: Add validation message

        NewProduct = new()
        {
            CategoryId = Category.CategoryId,
            ProductId = textBoxtId.Text,
            Name = textBoxtName.Text,
            Description = textBoxDescription.Text,
            Width = int.Parse(textBoxWidth.Text),
            Length = int.Parse(textBoxLength.Text),
            Height = int.Parse(textBoxHeight.Text),
        };
        DialogResult = DialogResult.OK;
        Close();
    }

    private bool ValidateDimension()
    {
        if (!int.TryParse(textBoxWidth.Text, out _))
        {
            errorProvider.SetError(textBoxWidth, "Width value is incorrect or empty");
            return false;
        }

        if (!int.TryParse(textBoxLength.Text, out _))
        {
            errorProvider.SetError(textBoxLength, "Length value is incorrect or empty");
            return false;
        }

        if (!int.TryParse(textBoxHeight.Text, out _))
        {
            errorProvider.SetError(textBoxHeight, "Height value is incorrect or empty");
            return false;
        }

        errorProvider.Clear();
        return true;
    }
}
