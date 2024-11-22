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
        categoryBindingSource = new BindingSource(components);
        dataGridViewProducts = new DataGridView();
        nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        dimensionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        productsBindingSource = new BindingSource(components);
        labelHeader = new Label();
        labelCategories = new Label();
        labelProducts = new Label();
        buttonPrint = new Button();
        buttonSave = new Button();
        pictureBox1 = new PictureBox();
        ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
        ((System.ComponentModel.ISupportInitialize)productsBindingSource).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
        dataGridViewProducts.AutoGenerateColumns = false;
        dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewProducts.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, dimensionDataGridViewTextBoxColumn });
        dataGridViewProducts.DataSource = productsBindingSource;
        dataGridViewProducts.Location = new Point(44, 179);
        dataGridViewProducts.Name = "dataGridViewProducts";
        dataGridViewProducts.Size = new Size(1169, 374);
        dataGridViewProducts.TabIndex = 1;
        dataGridViewProducts.SelectionChanged += dataGridViewProducts_SelectionChanged;
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
        // buttonPrint
        // 
        buttonPrint.Font = new Font("Segoe UI", 12F);
        buttonPrint.Location = new Point(179, 587);
        buttonPrint.Name = "buttonPrint";
        buttonPrint.Size = new Size(111, 36);
        buttonPrint.TabIndex = 5;
        buttonPrint.Text = "Print";
        buttonPrint.UseVisualStyleBackColor = true;
        buttonPrint.Click += buttonPrint_Click;
        // 
        // buttonSave
        // 
        buttonSave.Font = new Font("Segoe UI", 12F);
        buttonSave.Location = new Point(44, 587);
        buttonSave.Name = "buttonSave";
        buttonSave.Size = new Size(111, 36);
        buttonSave.TabIndex = 6;
        buttonSave.Text = "Save";
        buttonSave.UseVisualStyleBackColor = true;
        buttonSave.Click += buttonSave_Click;
        // 
        // pictureBox1
        // 
        pictureBox1.Location = new Point(896, 587);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(317, 85);
        pictureBox1.TabIndex = 7;
        pictureBox1.TabStop = false;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1343, 749);
        Controls.Add(pictureBox1);
        Controls.Add(buttonSave);
        Controls.Add(buttonPrint);
        Controls.Add(labelProducts);
        Controls.Add(labelCategories);
        Controls.Add(labelHeader);
        Controls.Add(dataGridViewProducts);
        Controls.Add(comboBoxCategories);
        Name = "MainForm";
        Text = "Numi Products";
        Load += MainForm_Load;
        ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
        ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
        ((System.ComponentModel.ISupportInitialize)productsBindingSource).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
    private Button buttonPrint;
    private Button buttonSave;
    private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn dimensionDataGridViewTextBoxColumn;
    private PictureBox pictureBox1;
}
