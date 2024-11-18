namespace numi;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        comboBoxCategories = new ComboBox();
        dataGridView1 = new DataGridView();
        categoryBindingSource = new BindingSource(components);
        productsBindingSource = new BindingSource(components);
        idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        dimensionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        categoryIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        categoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        labelHeader = new Label();
        labelCategories = new Label();
        labelProducts = new Label();
        buttonPrint = new Button();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
        ((System.ComponentModel.ISupportInitialize)productsBindingSource).BeginInit();
        SuspendLayout();
        // 
        // comboBoxCategories
        // 
        comboBoxCategories.DataSource = categoryBindingSource;
        comboBoxCategories.FormattingEnabled = true;
        comboBoxCategories.Location = new Point(217, 99);
        comboBoxCategories.Name = "comboBoxCategories";
        comboBoxCategories.Size = new Size(296, 23);
        comboBoxCategories.TabIndex = 0;
        // 
        // dataGridView1
        // 
        dataGridView1.AutoGenerateColumns = false;
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, dimensionDataGridViewTextBoxColumn, categoryIdDataGridViewTextBoxColumn, categoryDataGridViewTextBoxColumn });
        dataGridView1.DataSource = productsBindingSource;
        dataGridView1.Location = new Point(44, 179);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.Size = new Size(1169, 484);
        dataGridView1.TabIndex = 1;
        // 
        // categoryBindingSource
        // 
        categoryBindingSource.DataSource = typeof(src.domain.Models.Category);
        // 
        // productsBindingSource
        // 
        productsBindingSource.DataMember = "Products";
        productsBindingSource.DataSource = categoryBindingSource;
        // 
        // idDataGridViewTextBoxColumn
        // 
        idDataGridViewTextBoxColumn.DataPropertyName = "Id";
        idDataGridViewTextBoxColumn.HeaderText = "Id";
        idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
        // 
        // nameDataGridViewTextBoxColumn
        // 
        nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
        nameDataGridViewTextBoxColumn.HeaderText = "Name";
        nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
        // 
        // descriptionDataGridViewTextBoxColumn
        // 
        descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
        descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
        descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
        // 
        // dimensionDataGridViewTextBoxColumn
        // 
        dimensionDataGridViewTextBoxColumn.DataPropertyName = "Dimension";
        dimensionDataGridViewTextBoxColumn.HeaderText = "Dimension";
        dimensionDataGridViewTextBoxColumn.Name = "dimensionDataGridViewTextBoxColumn";
        // 
        // categoryIdDataGridViewTextBoxColumn
        // 
        categoryIdDataGridViewTextBoxColumn.DataPropertyName = "CategoryId";
        categoryIdDataGridViewTextBoxColumn.HeaderText = "CategoryId";
        categoryIdDataGridViewTextBoxColumn.Name = "categoryIdDataGridViewTextBoxColumn";
        // 
        // categoryDataGridViewTextBoxColumn
        // 
        categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
        categoryDataGridViewTextBoxColumn.HeaderText = "Category";
        categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
        // 
        // labelHeader
        // 
        labelHeader.AutoSize = true;
        labelHeader.Font = new Font("Segoe UI", 26F);
        labelHeader.Location = new Point(44, 25);
        labelHeader.Name = "labelHeader";
        labelHeader.Size = new Size(415, 47);
        labelHeader.TabIndex = 2;
        labelHeader.Text = "Numi Collection Products";
        // 
        // labelCategories
        // 
        labelCategories.AutoSize = true;
        labelCategories.Font = new Font("Segoe UI", 14F);
        labelCategories.Location = new Point(44, 94);
        labelCategories.Name = "labelCategories";
        labelCategories.Size = new Size(156, 25);
        labelCategories.TabIndex = 3;
        labelCategories.Text = "Product category";
        // 
        // labelProducts
        // 
        labelProducts.AutoSize = true;
        labelProducts.Font = new Font("Segoe UI", 14F);
        labelProducts.Location = new Point(44, 132);
        labelProducts.Name = "labelProducts";
        labelProducts.Size = new Size(86, 25);
        labelProducts.TabIndex = 4;
        labelProducts.Text = "Products";
        // 
        // buttonPrint
        // 
        buttonPrint.Font = new Font("Segoe UI", 12F);
        buttonPrint.Location = new Point(44, 692);
        buttonPrint.Name = "buttonPrint";
        buttonPrint.Size = new Size(111, 36);
        buttonPrint.TabIndex = 5;
        buttonPrint.Text = "Print";
        buttonPrint.UseVisualStyleBackColor = true;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1343, 771);
        Controls.Add(buttonPrint);
        Controls.Add(labelProducts);
        Controls.Add(labelCategories);
        Controls.Add(labelHeader);
        Controls.Add(dataGridView1);
        Controls.Add(comboBoxCategories);
        Name = "MainForm";
        Text = "Numi Products";
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
        ((System.ComponentModel.ISupportInitialize)productsBindingSource).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ComboBox comboBoxCategories;
    private DataGridView dataGridView1;
    private BindingSource categoryBindingSource;
    private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn dimensionDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
    private BindingSource productsBindingSource;
    private Label labelHeader;
    private Label labelCategories;
    private Label labelProducts;
    private Button buttonPrint;
}
