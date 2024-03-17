namespace Samuel_McMasters_C968
{
    partial class MainScreen
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
            this.dgvParts = new System.Windows.Forms.DataGridView();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.deletePartBtn = new System.Windows.Forms.Button();
            this.modifyPartBtn = new System.Windows.Forms.Button();
            this.addPartBtn = new System.Windows.Forms.Button();
            this.deleteProductBtn = new System.Windows.Forms.Button();
            this.modifyProductBtn = new System.Windows.Forms.Button();
            this.addProductBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.partsLabel = new System.Windows.Forms.Label();
            this.productsLabel = new System.Windows.Forms.Label();
            this.erpLabel = new System.Windows.Forms.Label();
            this.partSearchBox = new System.Windows.Forms.TextBox();
            this.partsSearchBtn = new System.Windows.Forms.Button();
            this.productSearchBox = new System.Windows.Forms.TextBox();
            this.productSearchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvParts
            // 
            this.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParts.Location = new System.Drawing.Point(12, 119);
            this.dgvParts.Name = "dgvParts";
            this.dgvParts.Size = new System.Drawing.Size(493, 241);
            this.dgvParts.TabIndex = 0;
            this.dgvParts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParts_CellContentClick);
            this.dgvParts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.myBindingComplete);
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(563, 119);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ShowCellErrors = false;
            this.dgvProducts.Size = new System.Drawing.Size(493, 241);
            this.dgvProducts.TabIndex = 1;
            // 
            // deletePartBtn
            // 
            this.deletePartBtn.Location = new System.Drawing.Point(413, 382);
            this.deletePartBtn.Name = "deletePartBtn";
            this.deletePartBtn.Size = new System.Drawing.Size(92, 35);
            this.deletePartBtn.TabIndex = 2;
            this.deletePartBtn.Text = "Delete Part";
            this.deletePartBtn.UseVisualStyleBackColor = true;
            this.deletePartBtn.Click += new System.EventHandler(this.deletePartBtn_Click);
            // 
            // modifyPartBtn
            // 
            this.modifyPartBtn.Location = new System.Drawing.Point(315, 382);
            this.modifyPartBtn.Name = "modifyPartBtn";
            this.modifyPartBtn.Size = new System.Drawing.Size(92, 35);
            this.modifyPartBtn.TabIndex = 3;
            this.modifyPartBtn.Text = "Modify Part";
            this.modifyPartBtn.UseVisualStyleBackColor = true;
            this.modifyPartBtn.Click += new System.EventHandler(this.modifyPartBtn_Click);
            // 
            // addPartBtn
            // 
            this.addPartBtn.Location = new System.Drawing.Point(217, 382);
            this.addPartBtn.Name = "addPartBtn";
            this.addPartBtn.Size = new System.Drawing.Size(92, 35);
            this.addPartBtn.TabIndex = 4;
            this.addPartBtn.Text = "Add Part";
            this.addPartBtn.UseVisualStyleBackColor = true;
            this.addPartBtn.Click += new System.EventHandler(this.addPartBtn_Click);
            // 
            // deleteProductBtn
            // 
            this.deleteProductBtn.Location = new System.Drawing.Point(964, 382);
            this.deleteProductBtn.Name = "deleteProductBtn";
            this.deleteProductBtn.Size = new System.Drawing.Size(92, 35);
            this.deleteProductBtn.TabIndex = 5;
            this.deleteProductBtn.Text = "Delete Product";
            this.deleteProductBtn.UseVisualStyleBackColor = true;
            this.deleteProductBtn.Click += new System.EventHandler(this.deleteProductBtn_Click);
            // 
            // modifyProductBtn
            // 
            this.modifyProductBtn.Location = new System.Drawing.Point(866, 382);
            this.modifyProductBtn.Name = "modifyProductBtn";
            this.modifyProductBtn.Size = new System.Drawing.Size(92, 35);
            this.modifyProductBtn.TabIndex = 6;
            this.modifyProductBtn.Text = "Modify Product";
            this.modifyProductBtn.UseVisualStyleBackColor = true;
            this.modifyProductBtn.Click += new System.EventHandler(this.modifyProductBtn_Click);
            // 
            // addProductBtn
            // 
            this.addProductBtn.Location = new System.Drawing.Point(768, 382);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Size = new System.Drawing.Size(92, 35);
            this.addProductBtn.TabIndex = 7;
            this.addProductBtn.Text = "Add Product";
            this.addProductBtn.UseVisualStyleBackColor = true;
            this.addProductBtn.Click += new System.EventHandler(this.addProductBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(964, 524);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(92, 35);
            this.exitBtn.TabIndex = 8;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // partsLabel
            // 
            this.partsLabel.AutoSize = true;
            this.partsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsLabel.Location = new System.Drawing.Point(12, 87);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(68, 29);
            this.partsLabel.TabIndex = 9;
            this.partsLabel.Text = "Parts";
            // 
            // productsLabel
            // 
            this.productsLabel.AutoSize = true;
            this.productsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsLabel.Location = new System.Drawing.Point(558, 87);
            this.productsLabel.Name = "productsLabel";
            this.productsLabel.Size = new System.Drawing.Size(108, 29);
            this.productsLabel.TabIndex = 10;
            this.productsLabel.Text = "Products";
            // 
            // erpLabel
            // 
            this.erpLabel.AutoSize = true;
            this.erpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erpLabel.Location = new System.Drawing.Point(12, 9);
            this.erpLabel.Name = "erpLabel";
            this.erpLabel.Size = new System.Drawing.Size(340, 29);
            this.erpLabel.TabIndex = 11;
            this.erpLabel.Text = "Inventory Management System";
            // 
            // partSearchBox
            // 
            this.partSearchBox.Location = new System.Drawing.Point(360, 87);
            this.partSearchBox.Name = "partSearchBox";
            this.partSearchBox.Size = new System.Drawing.Size(145, 20);
            this.partSearchBox.TabIndex = 12;
            this.partSearchBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // partsSearchBtn
            // 
            this.partsSearchBtn.Location = new System.Drawing.Point(279, 87);
            this.partsSearchBtn.Name = "partsSearchBtn";
            this.partsSearchBtn.Size = new System.Drawing.Size(75, 20);
            this.partsSearchBtn.TabIndex = 13;
            this.partsSearchBtn.Text = "Search";
            this.partsSearchBtn.UseVisualStyleBackColor = true;
            this.partsSearchBtn.Click += new System.EventHandler(this.partsSearchBtn_Click);
            // 
            // productSearchBox
            // 
            this.productSearchBox.Location = new System.Drawing.Point(911, 88);
            this.productSearchBox.Name = "productSearchBox";
            this.productSearchBox.Size = new System.Drawing.Size(145, 20);
            this.productSearchBox.TabIndex = 14;
            // 
            // productSearchBtn
            // 
            this.productSearchBtn.Location = new System.Drawing.Point(830, 88);
            this.productSearchBtn.Name = "productSearchBtn";
            this.productSearchBtn.Size = new System.Drawing.Size(75, 20);
            this.productSearchBtn.TabIndex = 15;
            this.productSearchBtn.Text = "Search";
            this.productSearchBtn.UseVisualStyleBackColor = true;
            this.productSearchBtn.Click += new System.EventHandler(this.productSearchBtn_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 571);
            this.Controls.Add(this.productSearchBtn);
            this.Controls.Add(this.productSearchBox);
            this.Controls.Add(this.partsSearchBtn);
            this.Controls.Add(this.partSearchBox);
            this.Controls.Add(this.erpLabel);
            this.Controls.Add(this.productsLabel);
            this.Controls.Add(this.partsLabel);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.addProductBtn);
            this.Controls.Add(this.modifyProductBtn);
            this.Controls.Add(this.deleteProductBtn);
            this.Controls.Add(this.addPartBtn);
            this.Controls.Add(this.modifyPartBtn);
            this.Controls.Add(this.deletePartBtn);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.dgvParts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainScreen";
            this.Text = "Main Screen";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button deletePartBtn;
        private System.Windows.Forms.Button modifyPartBtn;
        private System.Windows.Forms.Button addPartBtn;
        private System.Windows.Forms.Button deleteProductBtn;
        private System.Windows.Forms.Button modifyProductBtn;
        private System.Windows.Forms.Button addProductBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.Label productsLabel;
        private System.Windows.Forms.Label erpLabel;
        private System.Windows.Forms.TextBox partSearchBox;
        private System.Windows.Forms.Button partsSearchBtn;
        private System.Windows.Forms.TextBox productSearchBox;
        private System.Windows.Forms.Button productSearchBtn;
        public System.Windows.Forms.DataGridView dgvProducts;
        public System.Windows.Forms.DataGridView dgvParts;
    }
}

