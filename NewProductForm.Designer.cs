namespace numi
{
    partial class NewProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonAdd = new Button();
            labelId = new Label();
            textBoxtId = new TextBox();
            labelProductCategory = new Label();
            labelName = new Label();
            textBoxtName = new TextBox();
            labelDescription = new Label();
            textBoxDescription = new TextBox();
            labelWidth = new Label();
            textBoxWidth = new TextBox();
            buttonCancel = new Button();
            labelLength = new Label();
            textBoxLength = new TextBox();
            labelHeight = new Label();
            textBoxHeight = new TextBox();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(202, 512);
            buttonAdd.Margin = new Padding(5);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(118, 38);
            buttonAdd.TabIndex = 14;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(34, 154);
            labelId.Margin = new Padding(5, 0, 5, 0);
            labelId.Name = "labelId";
            labelId.Size = new Size(99, 25);
            labelId.TabIndex = 1;
            labelId.Text = "Product Id";
            // 
            // textBoxtId
            // 
            textBoxtId.Location = new Point(182, 147);
            textBoxtId.Margin = new Padding(5);
            textBoxtId.Name = "textBoxtId";
            textBoxtId.PlaceholderText = "25354";
            textBoxtId.Size = new Size(313, 32);
            textBoxtId.TabIndex = 2;
            // 
            // labelProductCategory
            // 
            labelProductCategory.AutoSize = true;
            labelProductCategory.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelProductCategory.Location = new Point(63, 53);
            labelProductCategory.Margin = new Padding(5, 0, 5, 0);
            labelProductCategory.Name = "labelProductCategory";
            labelProductCategory.Size = new Size(224, 37);
            labelProductCategory.TabIndex = 3;
            labelProductCategory.Text = "Product Category";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(71, 221);
            labelName.Margin = new Padding(5, 0, 5, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(62, 25);
            labelName.TabIndex = 3;
            labelName.Text = "Name";
            // 
            // textBoxtName
            // 
            textBoxtName.Location = new Point(182, 214);
            textBoxtName.Margin = new Padding(5);
            textBoxtName.Name = "textBoxtName";
            textBoxtName.PlaceholderText = "Product name";
            textBoxtName.Size = new Size(313, 32);
            textBoxtName.TabIndex = 4;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(25, 288);
            labelDescription.Margin = new Padding(5, 0, 5, 0);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(108, 25);
            labelDescription.TabIndex = 5;
            labelDescription.Text = "Description";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(182, 281);
            textBoxDescription.Margin = new Padding(5);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.PlaceholderText = "Household mattress";
            textBoxDescription.Size = new Size(313, 32);
            textBoxDescription.TabIndex = 6;
            // 
            // labelWidth
            // 
            labelWidth.AutoSize = true;
            labelWidth.Location = new Point(70, 355);
            labelWidth.Margin = new Padding(5, 0, 5, 0);
            labelWidth.Name = "labelWidth";
            labelWidth.Size = new Size(63, 25);
            labelWidth.TabIndex = 7;
            labelWidth.Text = "Width";
            // 
            // textBoxWidth
            // 
            textBoxWidth.Location = new Point(182, 348);
            textBoxWidth.Margin = new Padding(5);
            textBoxWidth.Name = "textBoxWidth";
            textBoxWidth.PlaceholderText = "90";
            textBoxWidth.Size = new Size(48, 32);
            textBoxWidth.TabIndex = 8;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(63, 512);
            buttonCancel.Margin = new Padding(5);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(118, 38);
            buttonCancel.TabIndex = 13;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // labelLength
            // 
            labelLength.AutoSize = true;
            labelLength.Location = new Point(265, 355);
            labelLength.Margin = new Padding(5, 0, 5, 0);
            labelLength.Name = "labelLength";
            labelLength.Size = new Size(70, 25);
            labelLength.TabIndex = 9;
            labelLength.Text = "Length";
            // 
            // textBoxLength
            // 
            textBoxLength.Location = new Point(361, 352);
            textBoxLength.Margin = new Padding(5);
            textBoxLength.Name = "textBoxLength";
            textBoxLength.PlaceholderText = "120";
            textBoxLength.Size = new Size(48, 32);
            textBoxLength.TabIndex = 10;
            // 
            // labelHeight
            // 
            labelHeight.AutoSize = true;
            labelHeight.Location = new Point(70, 404);
            labelHeight.Margin = new Padding(5, 0, 5, 0);
            labelHeight.Name = "labelHeight";
            labelHeight.Size = new Size(68, 25);
            labelHeight.TabIndex = 11;
            labelHeight.Text = "Height";
            // 
            // textBoxHeight
            // 
            textBoxHeight.Location = new Point(182, 401);
            textBoxHeight.Margin = new Padding(5);
            textBoxHeight.Name = "textBoxHeight";
            textBoxHeight.PlaceholderText = "25";
            textBoxHeight.Size = new Size(48, 32);
            textBoxHeight.TabIndex = 12;
            // 
            // NewProductForm
            // 
            AcceptButton = buttonAdd;
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(751, 603);
            Controls.Add(textBoxHeight);
            Controls.Add(labelHeight);
            Controls.Add(textBoxLength);
            Controls.Add(labelLength);
            Controls.Add(buttonCancel);
            Controls.Add(textBoxWidth);
            Controls.Add(labelWidth);
            Controls.Add(textBoxDescription);
            Controls.Add(labelDescription);
            Controls.Add(textBoxtName);
            Controls.Add(labelName);
            Controls.Add(labelProductCategory);
            Controls.Add(textBoxtId);
            Controls.Add(labelId);
            Controls.Add(buttonAdd);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            MaximizeBox = false;
            MaximumSize = new Size(767, 642);
            Name = "NewProductForm";
            ShowIcon = false;
            Text = "Add new product";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAdd;
        private Label labelId;
        private TextBox textBoxtId;
        private Label labelProductCategory;
        private Label labelName;
        private TextBox textBoxtName;
        private Label labelDescription;
        private TextBox textBoxDescription;
        private Label labelWidth;
        private TextBox textBoxWidth;
        private Button buttonCancel;
        private Label labelLength;
        private TextBox textBoxLength;
        private Label labelHeight;
        private TextBox textBoxHeight;
    }
}