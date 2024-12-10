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
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
        comboBoxCategories = new ComboBox();
        categoryBindingSource = new BindingSource(components);
        dataGridViewProducts = new DataGridView();
        ProductId = new DataGridViewTextBoxColumn();
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
        groupBox1 = new GroupBox();
        button1 = new Button();
        buttonDelete = new Button();
        button2 = new Button();
        buttonExportCSV = new Button();
        ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
        ((System.ComponentModel.ISupportInitialize)productsBindingSource).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictBxBarcode).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictBxQrcode).BeginInit();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // comboBoxCategories
        // 
        comboBoxCategories.DataSource = categoryBindingSource;
        comboBoxCategories.DisplayMember = "Name";
        comboBoxCategories.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        comboBoxCategories.FormattingEnabled = true;
        comboBoxCategories.Location = new Point(217, 113);
        comboBoxCategories.Name = "comboBoxCategories";
        comboBoxCategories.Size = new Size(296, 33);
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
        dataGridViewProducts.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        dataGridViewProducts.AutoGenerateColumns = false;
        dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridViewProducts.BackgroundColor = Color.White;
        dataGridViewProducts.CellBorderStyle = DataGridViewCellBorderStyle.None;
        dataGridViewProducts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = SystemColors.Control;
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
        dataGridViewCellStyle2.SelectionBackColor = SystemColors.HighlightText;
        dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
        dataGridViewProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewProducts.Columns.AddRange(new DataGridViewColumn[] { ProductId, nameDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, dimensionDataGridViewTextBoxColumn });
        dataGridViewProducts.DataSource = productsBindingSource;
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = SystemColors.Window;
        dataGridViewCellStyle3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
        dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
        dataGridViewProducts.DefaultCellStyle = dataGridViewCellStyle3;
        dataGridViewProducts.Location = new Point(44, 201);
        dataGridViewProducts.MultiSelect = false;
        dataGridViewProducts.Name = "dataGridViewProducts";
        dataGridViewProducts.ReadOnly = true;
        dataGridViewProducts.RowHeadersVisible = false;
        dataGridViewCellStyle4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        dataGridViewProducts.RowsDefaultCellStyle = dataGridViewCellStyle4;
        dataGridViewProducts.RowTemplate.Resizable = DataGridViewTriState.False;
        dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridViewProducts.Size = new Size(674, 420);
        dataGridViewProducts.TabIndex = 1;
        dataGridViewProducts.SelectionChanged += dataGridViewProducts_SelectionChanged;
        // 
        // ProductId
        // 
        ProductId.DataPropertyName = "ProductId";
        ProductId.HeaderText = "ProductId";
        ProductId.Name = "ProductId";
        ProductId.ReadOnly = true;
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
        labelHeader.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        labelHeader.Location = new Point(44, 25);
        labelHeader.Name = "labelHeader";
        labelHeader.Size = new Size(425, 50);
        labelHeader.TabIndex = 2;
        labelHeader.Text = "Numi Product Collection";
        // 
        // labelCategories
        // 
        labelCategories.AutoSize = true;
        labelCategories.Font = new Font("Segoe UI", 14F);
        labelCategories.Location = new Point(44, 116);
        labelCategories.Name = "labelCategories";
        labelCategories.Size = new Size(156, 25);
        labelCategories.TabIndex = 3;
        labelCategories.Text = "Product category";
        // 
        // labelProducts
        // 
        labelProducts.AutoSize = true;
        labelProducts.Font = new Font("Segoe UI", 14F);
        labelProducts.Location = new Point(44, 164);
        labelProducts.Name = "labelProducts";
        labelProducts.Size = new Size(86, 25);
        labelProducts.TabIndex = 4;
        labelProducts.Text = "Products";
        // 
        // buttonPrintBarcode
        // 
        buttonPrintBarcode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        buttonPrintBarcode.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        buttonPrintBarcode.Location = new Point(32, 178);
        buttonPrintBarcode.Name = "buttonPrintBarcode";
        buttonPrintBarcode.Size = new Size(429, 36);
        buttonPrintBarcode.TabIndex = 5;
        buttonPrintBarcode.Text = "Print";
        buttonPrintBarcode.UseVisualStyleBackColor = true;
        buttonPrintBarcode.Click += buttonPrintBarcode_Click;
        // 
        // pictBxBarcode
        // 
        pictBxBarcode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        pictBxBarcode.BackColor = Color.White;
        pictBxBarcode.Location = new Point(32, 47);
        pictBxBarcode.Name = "pictBxBarcode";
        pictBxBarcode.Size = new Size(429, 125);
        pictBxBarcode.SizeMode = PictureBoxSizeMode.CenterImage;
        pictBxBarcode.TabIndex = 7;
        pictBxBarcode.TabStop = false;
        // 
        // pictBxQrcode
        // 
        pictBxQrcode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        pictBxQrcode.BackColor = Color.White;
        pictBxQrcode.Location = new Point(32, 231);
        pictBxQrcode.Name = "pictBxQrcode";
        pictBxQrcode.Size = new Size(104, 104);
        pictBxQrcode.TabIndex = 8;
        pictBxQrcode.TabStop = false;
        // 
        // buttonPrintQrcode
        // 
        buttonPrintQrcode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        buttonPrintQrcode.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        buttonPrintQrcode.Location = new Point(32, 341);
        buttonPrintQrcode.Name = "buttonPrintQrcode";
        buttonPrintQrcode.Size = new Size(104, 36);
        buttonPrintQrcode.TabIndex = 9;
        buttonPrintQrcode.Text = "Print";
        buttonPrintQrcode.UseVisualStyleBackColor = true;
        buttonPrintQrcode.Click += buttonPrintQrcode_Click;
        // 
        // groupBox1
        // 
        groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        groupBox1.Controls.Add(pictBxBarcode);
        groupBox1.Controls.Add(buttonPrintQrcode);
        groupBox1.Controls.Add(buttonPrintBarcode);
        groupBox1.Controls.Add(pictBxQrcode);
        groupBox1.FlatStyle = FlatStyle.Popup;
        groupBox1.Font = new Font("Segoe UI", 14F);
        groupBox1.Location = new Point(767, 201);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(490, 420);
        groupBox1.TabIndex = 11;
        groupBox1.TabStop = false;
        groupBox1.Text = "Barcode printing";
        // 
        // button1
        // 
        button1.Font = new Font("Segoe UI", 14F);
        button1.Location = new Point(44, 643);
        button1.Margin = new Padding(3, 3, 10, 3);
        button1.Name = "button1";
        button1.Size = new Size(104, 36);
        button1.TabIndex = 12;
        button1.Text = "Add";
        button1.UseVisualStyleBackColor = true;
        button1.Click += buttonAdd_Click;
        // 
        // buttonDelete
        // 
        buttonDelete.Font = new Font("Segoe UI", 14F);
        buttonDelete.Location = new Point(161, 643);
        buttonDelete.Margin = new Padding(3, 3, 10, 3);
        buttonDelete.Name = "buttonDelete";
        buttonDelete.Size = new Size(104, 36);
        buttonDelete.TabIndex = 13;
        buttonDelete.Text = "Edit";
        buttonDelete.UseVisualStyleBackColor = true;
        // 
        // button2
        // 
        button2.Font = new Font("Segoe UI", 14F);
        button2.Location = new Point(278, 643);
        button2.Margin = new Padding(3, 3, 10, 3);
        button2.Name = "button2";
        button2.Size = new Size(104, 36);
        button2.TabIndex = 14;
        button2.Text = "Remove";
        button2.UseVisualStyleBackColor = true;
        button2.Click += buttonRemove;
        // 
        // buttonExportCSV
        // 
        buttonExportCSV.Font = new Font("Segoe UI", 14F);
        buttonExportCSV.Location = new Point(395, 643);
        buttonExportCSV.Margin = new Padding(3, 3, 10, 3);
        buttonExportCSV.Name = "buttonExportCSV";
        buttonExportCSV.Size = new Size(127, 36);
        buttonExportCSV.TabIndex = 15;
        buttonExportCSV.Text = "Export CSV";
        buttonExportCSV.UseVisualStyleBackColor = true;
        buttonExportCSV.Click += buttonExportCSV_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1343, 749);
        Controls.Add(buttonExportCSV);
        Controls.Add(button2);
        Controls.Add(buttonDelete);
        Controls.Add(button1);
        Controls.Add(groupBox1);
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
        groupBox1.ResumeLayout(false);
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
    private PictureBox pictBxBarcode;
    private PictureBox pictBxQrcode;
    private Button buttonPrintQrcode;
    private GroupBox groupBox1;
    private Button button1;
    private Button buttonDelete;
    private Button button2;
    private DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn ProductId;
    private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn dimensionDataGridViewTextBoxColumn;
    private Button buttonExportCSV;
}
