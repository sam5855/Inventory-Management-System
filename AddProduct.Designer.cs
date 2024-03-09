namespace Samuel_McMasters_C968
{
    partial class AddProduct
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
            this.minLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.minTextbox = new System.Windows.Forms.TextBox();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.inventoryTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.addProductLabel = new System.Windows.Forms.Label();
            this.dgvCandidateParts = new System.Windows.Forms.DataGridView();
            this.candidatePartsLabel = new System.Windows.Forms.Label();
            this.associatedPartsLabel = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.candidatePartSearchBox = new System.Windows.Forms.TextBox();
            this.candidatePartSearchBtn = new System.Windows.Forms.Button();
            this.candidatePartAddBtn = new System.Windows.Forms.Button();
            this.partDeleteBtn = new System.Windows.Forms.Button();
            this.productSaveBtn = new System.Windows.Forms.Button();
            this.productCancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidateParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel.Location = new System.Drawing.Point(282, 374);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(41, 24);
            this.minLabel.TabIndex = 43;
            this.minLabel.Text = "Min";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel.Location = new System.Drawing.Point(96, 374);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(46, 24);
            this.maxLabel.TabIndex = 42;
            this.maxLabel.Text = "Max";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(89, 323);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(53, 24);
            this.priceLabel.TabIndex = 41;
            this.priceLabel.Text = "Price";
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryLabel.Location = new System.Drawing.Point(56, 270);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(86, 24);
            this.inventoryLabel.TabIndex = 40;
            this.inventoryLabel.Text = "Inventory";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(81, 220);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(61, 24);
            this.nameLabel.TabIndex = 39;
            this.nameLabel.Text = "Name";
            // 
            // minTextbox
            // 
            this.minTextbox.Location = new System.Drawing.Point(352, 374);
            this.minTextbox.Multiline = true;
            this.minTextbox.Name = "minTextbox";
            this.minTextbox.Size = new System.Drawing.Size(82, 28);
            this.minTextbox.TabIndex = 38;
            // 
            // maxTextBox
            // 
            this.maxTextBox.Location = new System.Drawing.Point(173, 374);
            this.maxTextBox.Multiline = true;
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(82, 28);
            this.maxTextBox.TabIndex = 37;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(173, 323);
            this.priceTextBox.Multiline = true;
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(165, 28);
            this.priceTextBox.TabIndex = 36;
            // 
            // inventoryTextBox
            // 
            this.inventoryTextBox.Location = new System.Drawing.Point(173, 270);
            this.inventoryTextBox.Multiline = true;
            this.inventoryTextBox.Name = "inventoryTextBox";
            this.inventoryTextBox.Size = new System.Drawing.Size(165, 28);
            this.inventoryTextBox.TabIndex = 35;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(173, 220);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(165, 28);
            this.nameTextBox.TabIndex = 34;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(173, 175);
            this.idTextBox.Multiline = true;
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(165, 28);
            this.idTextBox.TabIndex = 33;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(115, 175);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(27, 24);
            this.idLabel.TabIndex = 32;
            this.idLabel.Text = "ID";
            // 
            // addProductLabel
            // 
            this.addProductLabel.AutoSize = true;
            this.addProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductLabel.Location = new System.Drawing.Point(36, 23);
            this.addProductLabel.Name = "addProductLabel";
            this.addProductLabel.Size = new System.Drawing.Size(130, 25);
            this.addProductLabel.TabIndex = 44;
            this.addProductLabel.Text = "Add Product";
            // 
            // dgvCandidateParts
            // 
            this.dgvCandidateParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidateParts.Location = new System.Drawing.Point(478, 94);
            this.dgvCandidateParts.Name = "dgvCandidateParts";
            this.dgvCandidateParts.Size = new System.Drawing.Size(495, 150);
            this.dgvCandidateParts.TabIndex = 45;
            // 
            // candidatePartsLabel
            // 
            this.candidatePartsLabel.AutoSize = true;
            this.candidatePartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candidatePartsLabel.Location = new System.Drawing.Point(473, 66);
            this.candidatePartsLabel.Name = "candidatePartsLabel";
            this.candidatePartsLabel.Size = new System.Drawing.Size(144, 20);
            this.candidatePartsLabel.TabIndex = 46;
            this.candidatePartsLabel.Text = "All Candidate Parts";
            // 
            // associatedPartsLabel
            // 
            this.associatedPartsLabel.AutoSize = true;
            this.associatedPartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.associatedPartsLabel.Location = new System.Drawing.Point(472, 333);
            this.associatedPartsLabel.Name = "associatedPartsLabel";
            this.associatedPartsLabel.Size = new System.Drawing.Size(249, 20);
            this.associatedPartsLabel.TabIndex = 48;
            this.associatedPartsLabel.Text = "Parts Associated with this Product";
            this.associatedPartsLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(477, 361);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(495, 150);
            this.dataGridView2.TabIndex = 47;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // candidatePartSearchBox
            // 
            this.candidatePartSearchBox.Location = new System.Drawing.Point(814, 66);
            this.candidatePartSearchBox.Name = "candidatePartSearchBox";
            this.candidatePartSearchBox.Size = new System.Drawing.Size(158, 20);
            this.candidatePartSearchBox.TabIndex = 49;
            // 
            // candidatePartSearchBtn
            // 
            this.candidatePartSearchBtn.Location = new System.Drawing.Point(733, 66);
            this.candidatePartSearchBtn.Name = "candidatePartSearchBtn";
            this.candidatePartSearchBtn.Size = new System.Drawing.Size(75, 20);
            this.candidatePartSearchBtn.TabIndex = 50;
            this.candidatePartSearchBtn.Text = "Search";
            this.candidatePartSearchBtn.UseVisualStyleBackColor = true;
            // 
            // candidatePartAddBtn
            // 
            this.candidatePartAddBtn.Location = new System.Drawing.Point(900, 250);
            this.candidatePartAddBtn.Name = "candidatePartAddBtn";
            this.candidatePartAddBtn.Size = new System.Drawing.Size(72, 34);
            this.candidatePartAddBtn.TabIndex = 51;
            this.candidatePartAddBtn.Text = "Add";
            this.candidatePartAddBtn.UseVisualStyleBackColor = true;
            // 
            // partDeleteBtn
            // 
            this.partDeleteBtn.Location = new System.Drawing.Point(901, 517);
            this.partDeleteBtn.Name = "partDeleteBtn";
            this.partDeleteBtn.Size = new System.Drawing.Size(72, 34);
            this.partDeleteBtn.TabIndex = 52;
            this.partDeleteBtn.Text = "Delete";
            this.partDeleteBtn.UseVisualStyleBackColor = true;
            // 
            // productSaveBtn
            // 
            this.productSaveBtn.Location = new System.Drawing.Point(814, 642);
            this.productSaveBtn.Name = "productSaveBtn";
            this.productSaveBtn.Size = new System.Drawing.Size(98, 45);
            this.productSaveBtn.TabIndex = 53;
            this.productSaveBtn.Text = "Save";
            this.productSaveBtn.UseVisualStyleBackColor = true;
            // 
            // productCancelBtn
            // 
            this.productCancelBtn.Location = new System.Drawing.Point(930, 642);
            this.productCancelBtn.Name = "productCancelBtn";
            this.productCancelBtn.Size = new System.Drawing.Size(98, 45);
            this.productCancelBtn.TabIndex = 54;
            this.productCancelBtn.Text = "Cancel";
            this.productCancelBtn.UseVisualStyleBackColor = true;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 699);
            this.Controls.Add(this.productCancelBtn);
            this.Controls.Add(this.productSaveBtn);
            this.Controls.Add(this.partDeleteBtn);
            this.Controls.Add(this.candidatePartAddBtn);
            this.Controls.Add(this.candidatePartSearchBtn);
            this.Controls.Add(this.candidatePartSearchBox);
            this.Controls.Add(this.associatedPartsLabel);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.candidatePartsLabel);
            this.Controls.Add(this.dgvCandidateParts);
            this.Controls.Add(this.addProductLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.minTextbox);
            this.Controls.Add(this.maxTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.inventoryTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.idLabel);
            this.Name = "AddProduct";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidateParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox minTextbox;
        private System.Windows.Forms.TextBox maxTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox inventoryTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label addProductLabel;
        private System.Windows.Forms.DataGridView dgvCandidateParts;
        private System.Windows.Forms.Label candidatePartsLabel;
        private System.Windows.Forms.Label associatedPartsLabel;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox candidatePartSearchBox;
        private System.Windows.Forms.Button candidatePartSearchBtn;
        private System.Windows.Forms.Button candidatePartAddBtn;
        private System.Windows.Forms.Button partDeleteBtn;
        private System.Windows.Forms.Button productSaveBtn;
        private System.Windows.Forms.Button productCancelBtn;
    }
}