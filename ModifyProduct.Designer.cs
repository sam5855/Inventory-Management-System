namespace Samuel_McMasters_C968
{
    partial class ModifyProduct
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
            this.productCancelBtn = new System.Windows.Forms.Button();
            this.productSaveBtn = new System.Windows.Forms.Button();
            this.partDeleteBtn = new System.Windows.Forms.Button();
            this.candidatePartAddBtn = new System.Windows.Forms.Button();
            this.candidatePartSearchBtn = new System.Windows.Forms.Button();
            this.candidatePartSearchBox = new System.Windows.Forms.TextBox();
            this.associatedPartsLabel = new System.Windows.Forms.Label();
            this.dgvModifyAssociatedParts = new System.Windows.Forms.DataGridView();
            this.candidatePartsLabel = new System.Windows.Forms.Label();
            this.dgvModifyCandidateParts = new System.Windows.Forms.DataGridView();
            this.addProductLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.modProdMinTextBox = new System.Windows.Forms.TextBox();
            this.modProdMaxTextBox = new System.Windows.Forms.TextBox();
            this.modProdPriceTextBox = new System.Windows.Forms.TextBox();
            this.modProdInventoryTextBox = new System.Windows.Forms.TextBox();
            this.modProdNameTextBox = new System.Windows.Forms.TextBox();
            this.modProdIDTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModifyAssociatedParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModifyCandidateParts)).BeginInit();
            this.SuspendLayout();
            // 
            // productCancelBtn
            // 
            this.productCancelBtn.Location = new System.Drawing.Point(918, 636);
            this.productCancelBtn.Name = "productCancelBtn";
            this.productCancelBtn.Size = new System.Drawing.Size(98, 45);
            this.productCancelBtn.TabIndex = 77;
            this.productCancelBtn.Text = "Cancel";
            this.productCancelBtn.UseVisualStyleBackColor = true;
            this.productCancelBtn.Click += new System.EventHandler(this.productCancelBtn_Click);
            // 
            // productSaveBtn
            // 
            this.productSaveBtn.Location = new System.Drawing.Point(802, 636);
            this.productSaveBtn.Name = "productSaveBtn";
            this.productSaveBtn.Size = new System.Drawing.Size(98, 45);
            this.productSaveBtn.TabIndex = 76;
            this.productSaveBtn.Text = "Save";
            this.productSaveBtn.UseVisualStyleBackColor = true;
            this.productSaveBtn.Click += new System.EventHandler(this.productSaveBtn_Click);
            // 
            // partDeleteBtn
            // 
            this.partDeleteBtn.Location = new System.Drawing.Point(889, 511);
            this.partDeleteBtn.Name = "partDeleteBtn";
            this.partDeleteBtn.Size = new System.Drawing.Size(72, 34);
            this.partDeleteBtn.TabIndex = 75;
            this.partDeleteBtn.Text = "Delete";
            this.partDeleteBtn.UseVisualStyleBackColor = true;
            this.partDeleteBtn.Click += new System.EventHandler(this.partDeleteBtn_Click);
            // 
            // candidatePartAddBtn
            // 
            this.candidatePartAddBtn.Location = new System.Drawing.Point(888, 244);
            this.candidatePartAddBtn.Name = "candidatePartAddBtn";
            this.candidatePartAddBtn.Size = new System.Drawing.Size(72, 34);
            this.candidatePartAddBtn.TabIndex = 74;
            this.candidatePartAddBtn.Text = "Add";
            this.candidatePartAddBtn.UseVisualStyleBackColor = true;
            this.candidatePartAddBtn.Click += new System.EventHandler(this.candidatePartAddBtn_Click);
            // 
            // candidatePartSearchBtn
            // 
            this.candidatePartSearchBtn.Location = new System.Drawing.Point(721, 60);
            this.candidatePartSearchBtn.Name = "candidatePartSearchBtn";
            this.candidatePartSearchBtn.Size = new System.Drawing.Size(75, 20);
            this.candidatePartSearchBtn.TabIndex = 73;
            this.candidatePartSearchBtn.Text = "Search";
            this.candidatePartSearchBtn.UseVisualStyleBackColor = true;
            this.candidatePartSearchBtn.Click += new System.EventHandler(this.candidatePartSearchBtn_Click);
            // 
            // candidatePartSearchBox
            // 
            this.candidatePartSearchBox.Location = new System.Drawing.Point(802, 60);
            this.candidatePartSearchBox.Name = "candidatePartSearchBox";
            this.candidatePartSearchBox.Size = new System.Drawing.Size(158, 20);
            this.candidatePartSearchBox.TabIndex = 72;
            // 
            // associatedPartsLabel
            // 
            this.associatedPartsLabel.AutoSize = true;
            this.associatedPartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.associatedPartsLabel.Location = new System.Drawing.Point(460, 327);
            this.associatedPartsLabel.Name = "associatedPartsLabel";
            this.associatedPartsLabel.Size = new System.Drawing.Size(249, 20);
            this.associatedPartsLabel.TabIndex = 71;
            this.associatedPartsLabel.Text = "Parts Associated with this Product";
            // 
            // dgvModifyAssociatedParts
            // 
            this.dgvModifyAssociatedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModifyAssociatedParts.Location = new System.Drawing.Point(465, 355);
            this.dgvModifyAssociatedParts.Name = "dgvModifyAssociatedParts";
            this.dgvModifyAssociatedParts.Size = new System.Drawing.Size(495, 150);
            this.dgvModifyAssociatedParts.TabIndex = 70;
            // 
            // candidatePartsLabel
            // 
            this.candidatePartsLabel.AutoSize = true;
            this.candidatePartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candidatePartsLabel.Location = new System.Drawing.Point(461, 60);
            this.candidatePartsLabel.Name = "candidatePartsLabel";
            this.candidatePartsLabel.Size = new System.Drawing.Size(144, 20);
            this.candidatePartsLabel.TabIndex = 69;
            this.candidatePartsLabel.Text = "All Candidate Parts";
            // 
            // dgvModifyCandidateParts
            // 
            this.dgvModifyCandidateParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModifyCandidateParts.Location = new System.Drawing.Point(466, 88);
            this.dgvModifyCandidateParts.Name = "dgvModifyCandidateParts";
            this.dgvModifyCandidateParts.Size = new System.Drawing.Size(495, 150);
            this.dgvModifyCandidateParts.TabIndex = 68;
            this.dgvModifyCandidateParts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.myBindingComplete);
            // 
            // addProductLabel
            // 
            this.addProductLabel.AutoSize = true;
            this.addProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductLabel.Location = new System.Drawing.Point(24, 17);
            this.addProductLabel.Name = "addProductLabel";
            this.addProductLabel.Size = new System.Drawing.Size(156, 25);
            this.addProductLabel.TabIndex = 67;
            this.addProductLabel.Text = "Modify Product";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel.Location = new System.Drawing.Point(270, 368);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(41, 24);
            this.minLabel.TabIndex = 66;
            this.minLabel.Text = "Min";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel.Location = new System.Drawing.Point(84, 368);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(46, 24);
            this.maxLabel.TabIndex = 65;
            this.maxLabel.Text = "Max";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(77, 317);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(53, 24);
            this.priceLabel.TabIndex = 64;
            this.priceLabel.Text = "Price";
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryLabel.Location = new System.Drawing.Point(44, 264);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(86, 24);
            this.inventoryLabel.TabIndex = 63;
            this.inventoryLabel.Text = "Inventory";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(69, 214);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(61, 24);
            this.nameLabel.TabIndex = 62;
            this.nameLabel.Text = "Name";
            // 
            // modProdMinTextBox
            // 
            this.modProdMinTextBox.Location = new System.Drawing.Point(340, 368);
            this.modProdMinTextBox.Multiline = true;
            this.modProdMinTextBox.Name = "modProdMinTextBox";
            this.modProdMinTextBox.Size = new System.Drawing.Size(82, 28);
            this.modProdMinTextBox.TabIndex = 61;
            // 
            // modProdMaxTextBox
            // 
            this.modProdMaxTextBox.Location = new System.Drawing.Point(161, 368);
            this.modProdMaxTextBox.Multiline = true;
            this.modProdMaxTextBox.Name = "modProdMaxTextBox";
            this.modProdMaxTextBox.Size = new System.Drawing.Size(82, 28);
            this.modProdMaxTextBox.TabIndex = 60;
            // 
            // modProdPriceTextBox
            // 
            this.modProdPriceTextBox.Location = new System.Drawing.Point(161, 317);
            this.modProdPriceTextBox.Multiline = true;
            this.modProdPriceTextBox.Name = "modProdPriceTextBox";
            this.modProdPriceTextBox.Size = new System.Drawing.Size(165, 28);
            this.modProdPriceTextBox.TabIndex = 59;
            // 
            // modProdInventoryTextBox
            // 
            this.modProdInventoryTextBox.Location = new System.Drawing.Point(161, 264);
            this.modProdInventoryTextBox.Multiline = true;
            this.modProdInventoryTextBox.Name = "modProdInventoryTextBox";
            this.modProdInventoryTextBox.Size = new System.Drawing.Size(165, 28);
            this.modProdInventoryTextBox.TabIndex = 58;
            // 
            // modProdNameTextBox
            // 
            this.modProdNameTextBox.Location = new System.Drawing.Point(161, 214);
            this.modProdNameTextBox.Multiline = true;
            this.modProdNameTextBox.Name = "modProdNameTextBox";
            this.modProdNameTextBox.Size = new System.Drawing.Size(165, 28);
            this.modProdNameTextBox.TabIndex = 57;
            // 
            // modProdIDTextBox
            // 
            this.modProdIDTextBox.Enabled = false;
            this.modProdIDTextBox.Location = new System.Drawing.Point(161, 169);
            this.modProdIDTextBox.Multiline = true;
            this.modProdIDTextBox.Name = "modProdIDTextBox";
            this.modProdIDTextBox.ReadOnly = true;
            this.modProdIDTextBox.Size = new System.Drawing.Size(165, 28);
            this.modProdIDTextBox.TabIndex = 56;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(103, 169);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(27, 24);
            this.idLabel.TabIndex = 55;
            this.idLabel.Text = "ID";
            // 
            // ModifyProduct
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
            this.Controls.Add(this.dgvModifyAssociatedParts);
            this.Controls.Add(this.candidatePartsLabel);
            this.Controls.Add(this.dgvModifyCandidateParts);
            this.Controls.Add(this.addProductLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.modProdMinTextBox);
            this.Controls.Add(this.modProdMaxTextBox);
            this.Controls.Add(this.modProdPriceTextBox);
            this.Controls.Add(this.modProdInventoryTextBox);
            this.Controls.Add(this.modProdNameTextBox);
            this.Controls.Add(this.modProdIDTextBox);
            this.Controls.Add(this.idLabel);
            this.Name = "ModifyProduct";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.ModifyProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModifyAssociatedParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModifyCandidateParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button productCancelBtn;
        private System.Windows.Forms.Button productSaveBtn;
        private System.Windows.Forms.Button partDeleteBtn;
        private System.Windows.Forms.Button candidatePartAddBtn;
        private System.Windows.Forms.Button candidatePartSearchBtn;
        private System.Windows.Forms.TextBox candidatePartSearchBox;
        private System.Windows.Forms.Label associatedPartsLabel;
        private System.Windows.Forms.DataGridView dgvModifyAssociatedParts;
        private System.Windows.Forms.Label candidatePartsLabel;
        private System.Windows.Forms.DataGridView dgvModifyCandidateParts;
        private System.Windows.Forms.Label addProductLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox modProdMinTextBox;
        private System.Windows.Forms.TextBox modProdMaxTextBox;
        private System.Windows.Forms.TextBox modProdPriceTextBox;
        private System.Windows.Forms.TextBox modProdInventoryTextBox;
        private System.Windows.Forms.TextBox modProdNameTextBox;
        private System.Windows.Forms.TextBox modProdIDTextBox;
        private System.Windows.Forms.Label idLabel;
    }
}