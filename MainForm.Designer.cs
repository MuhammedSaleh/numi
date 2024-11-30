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
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        comboBoxCategories = new ComboBox();
        categoryBindingSource = new BindingSource(components);
        dataGridViewProducts = new DataGridView();
        nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        dimensionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        productsBindingSource = new BindingSource(components);
        labelHeader = new Label();
        labelCategories = new Label();
        labelProducts = new Label();
        buttonPrintBarcode = new Button();
        pictBxBarcode = new PictureBox();
        pictBxQrcode = new PictureBox();
        buttonPrintQrcode = new Button();
        ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
        ((System.ComponentModel.ISupportInitialize)productsBindingSource).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictBxBarcode).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictBxQrcode).BeginInit();
        SuspendLayout();
        // 
        // comboBoxCategories
        // 
        comboBoxCategories.DataSource = categoryBindingSource;
        comboBoxCategories.DisplayMember = "Name";
        comboBoxCategories.FormattingEnabled = true;
        comboBoxCategories.Location = new Point(217, 99);
        comboBoxCategories.Name = "comboBoxCategories";
        comboBoxCategories.Size = new Size(296, 23);
        comboBoxCategories.TabIndex = 0;
        comboBoxCategories.SelectedIndexChanged += comboBoxCategories_SelectedIndexChanged;
        // 
        // categoryBindingSource
        // 
        categoryBindingSource.DataSource = typeof(src.domain.Models.Category);
        // 
        // dataGridViewProducts
        // 
        dataGridViewProducts.AllowUserToAddRows = false;
        dataGridViewProducts.AllowUserToDeleteRows = false;
        dataGridViewCellStyle1.BackColor = SystemColors.GradientActiveCaption;
        dataGridViewProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dataGridViewProducts.AutoGenerateColumns = false;
        dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridViewProducts.BackgroundColor = Color.White;
        dataGridViewProducts.BorderStyle = BorderStyle.Fixed3D;
        dataGridViewProducts.CellBorderStyle = DataGridViewCellBorderStyle.None;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = SystemColors.Control;
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
        dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
        dataGridViewCellStyle2.SelectionBackColor = SystemColors.HighlightText;
        dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
        dataGridViewProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewProducts.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, dimensionDataGridViewTextBoxColumn });
        dataGridViewProducts.DataSource = productsBindingSource;
        dataGridViewProducts.Location = new Point(44, 179);
        dataGridViewProducts.Name = "dataGridViewProducts";
        dataGridViewProducts.ReadOnly = true;
        dataGridViewProducts.RowHeadersVisible = false;
        dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridViewProducts.Size = new Size(830, 348);
        dataGridViewProducts.TabIndex = 1;
        dataGridViewProducts.SelectionChanged += dataGridViewProducts_SelectionChanged;
        // 
        // nameDataGridViewTextBoxColumn
        // 
        nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
        nameDataGridViewTextBoxColumn.HeaderText = "Name";
        nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
        nameDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // descriptionDataGridViewTextBoxColumn
        // 
        descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
        descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
        descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
        descriptionDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // dimensionDataGridViewTextBoxColumn
        // 
        dimensionDataGridViewTextBoxColumn.DataPropertyName = "Dimension";
        dimensionDataGridViewTextBoxColumn.HeaderText = "Dimension";
        dimensionDataGridViewTextBoxColumn.Name = "dimensionDataGridViewTextBoxColumn";
        dimensionDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // productsBindingSource
        // 
        productsBindingSource.DataMember = "Products";
        productsBindingSource.DataSource = categoryBindingSource;
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
        labelProducts.Location = new Point(44, 142);
        labelProducts.Name = "labelProducts";
        labelProducts.Size = new Size(86, 25);
        labelProducts.TabIndex = 4;
        labelProducts.Text = "Products";
        // 
        // buttonPrintBarcode
        // 
        buttonPrintBarcode.Font = new Font("Segoe UI", 12F);
        buttonPrintBarcode.Location = new Point(924, 292);
        buttonPrintBarcode.Name = "buttonPrintBarcode";
        buttonPrintBarcode.Size = new Size(111, 36);
        buttonPrintBarcode.TabIndex = 5;
        buttonPrintBarcode.Text = "Print";
        buttonPrintBarcode.UseVisualStyleBackColor = true;
        buttonPrintBarcode.Click += buttonPrintBarcode_Click;
        // 
        // pictBxBarcode
        // 
        pictBxBarcode.BackColor = Color.White;
        pictBxBarcode.Location = new Point(924, 179);
        pictBxBarcode.Name = "pictBxBarcode";
        pictBxBarcode.Size = new Size(387, 107);
        pictBxBarcode.SizeMode = PictureBoxSizeMode.CenterImage;
        pictBxBarcode.TabIndex = 7;
        pictBxBarcode.TabStop = false;
        // 
        // pictBxQrcode
        // 
        pictBxQrcode.BackColor = Color.White;
        pictBxQrcode.Location = new Point(924, 401);
        pictBxQrcode.Name = "pictBxQrcode";
        pictBxQrcode.Size = new Size(104, 104);
        pictBxQrcode.TabIndex = 8;
        pictBxQrcode.TabStop = false;
        // 
        // buttonPrintQrcode
        // 
        buttonPrintQrcode.Font = new Font("Segoe UI", 12F);
        buttonPrintQrcode.Location = new Point(924, 511);
        buttonPrintQrcode.Name = "buttonPrintQrcode";
        buttonPrintQrcode.Size = new Size(111, 36);
        buttonPrintQrcode.TabIndex = 9;
        buttonPrintQrcode.Text = "Print";
        buttonPrintQrcode.UseVisualStyleBackColor = true;
        buttonPrintQrcode.Click += buttonPrintQrcode_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1343, 749);
        Controls.Add(buttonPrintQrcode);
        Controls.Add(pictBxQrcode);
        Controls.Add(pictBxBarcode);
        Controls.Add(buttonPrintBarcode);
        Controls.Add(labelProducts);
        Controls.Add(labelCategories);
        Controls.Add(labelHeader);
        Controls.Add(dataGridViewProducts);
        Controls.Add(comboBoxCategories);
        Name = "MainForm";
        Text = "Numi Products";
        ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
        ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
        ((System.ComponentModel.ISupportInitialize)productsBindingSource).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictBxBarcode).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictBxQrcode).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ComboBox comboBoxCategories;
    private DataGridView dataGridViewProducts;
    private BindingSource categoryBindingSource;
    private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    private BindingSource productsBindingSource;
    private Label labelHeader;
    private Label labelCategories;
    private Label labelProducts;
    private Button buttonPrintBarcode;
    private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn dimensionDataGridViewTextBoxColumn;
    private PictureBox pictBxBarcode;
    private PictureBox pictBxQrcode;
    private Button buttonPrintQrcode;
}
