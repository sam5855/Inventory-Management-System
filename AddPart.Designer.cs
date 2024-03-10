namespace Samuel_McMasters_C968
{
    partial class AddPartScreen
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
            this.addPartLabel = new System.Windows.Forms.Label();
            this.inHouseBtn = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.idLabel = new System.Windows.Forms.Label();
            this.addPartIDTextBox = new System.Windows.Forms.TextBox();
            this.addPartNameTextBox = new System.Windows.Forms.TextBox();
            this.addPartInventoryTextBox = new System.Windows.Forms.TextBox();
            this.addPartPriceTextBox = new System.Windows.Forms.TextBox();
            this.addPartMaxTextBox = new System.Windows.Forms.TextBox();
            this.addPartMinTextbox = new System.Windows.Forms.TextBox();
            this.addPartMachineCompanyTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.machineCompanyLabel = new System.Windows.Forms.Label();
            this.partSaveBtn = new System.Windows.Forms.Button();
            this.partCancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addPartLabel
            // 
            this.addPartLabel.AutoSize = true;
            this.addPartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartLabel.Location = new System.Drawing.Point(12, 9);
            this.addPartLabel.Name = "addPartLabel";
            this.addPartLabel.Size = new System.Drawing.Size(95, 25);
            this.addPartLabel.TabIndex = 0;
            this.addPartLabel.Text = "Add Part";
            // 
            // inHouseBtn
            // 
            this.inHouseBtn.AutoSize = true;
            this.inHouseBtn.Checked = true;
            this.inHouseBtn.Location = new System.Drawing.Point(189, 17);
            this.inHouseBtn.Name = "inHouseBtn";
            this.inHouseBtn.Size = new System.Drawing.Size(68, 17);
            this.inHouseBtn.TabIndex = 1;
            this.inHouseBtn.TabStop = true;
            this.inHouseBtn.Text = "In-House";
            this.inHouseBtn.UseVisualStyleBackColor = true;
            this.inHouseBtn.CheckedChanged += new System.EventHandler(this.inHouseBtn_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(279, 17);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(80, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.Text = "Outsourced";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(160, 91);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(27, 24);
            this.idLabel.TabIndex = 3;
            this.idLabel.Text = "ID";
            // 
            // addPartIDTextBox
            // 
            this.addPartIDTextBox.Enabled = false;
            this.addPartIDTextBox.Location = new System.Drawing.Point(260, 91);
            this.addPartIDTextBox.Multiline = true;
            this.addPartIDTextBox.Name = "addPartIDTextBox";
            this.addPartIDTextBox.ReadOnly = true;
            this.addPartIDTextBox.Size = new System.Drawing.Size(165, 28);
            this.addPartIDTextBox.TabIndex = 4;
            // 
            // addPartNameTextBox
            // 
            this.addPartNameTextBox.Location = new System.Drawing.Point(260, 136);
            this.addPartNameTextBox.Multiline = true;
            this.addPartNameTextBox.Name = "addPartNameTextBox";
            this.addPartNameTextBox.Size = new System.Drawing.Size(165, 28);
            this.addPartNameTextBox.TabIndex = 5;
            // 
            // addPartInventoryTextBox
            // 
            this.addPartInventoryTextBox.Location = new System.Drawing.Point(260, 186);
            this.addPartInventoryTextBox.Multiline = true;
            this.addPartInventoryTextBox.Name = "addPartInventoryTextBox";
            this.addPartInventoryTextBox.Size = new System.Drawing.Size(165, 28);
            this.addPartInventoryTextBox.TabIndex = 6;
            // 
            // addPartPriceTextBox
            // 
            this.addPartPriceTextBox.Location = new System.Drawing.Point(260, 239);
            this.addPartPriceTextBox.Multiline = true;
            this.addPartPriceTextBox.Name = "addPartPriceTextBox";
            this.addPartPriceTextBox.Size = new System.Drawing.Size(165, 28);
            this.addPartPriceTextBox.TabIndex = 7;
            // 
            // addPartMaxTextBox
            // 
            this.addPartMaxTextBox.Location = new System.Drawing.Point(260, 290);
            this.addPartMaxTextBox.Multiline = true;
            this.addPartMaxTextBox.Name = "addPartMaxTextBox";
            this.addPartMaxTextBox.Size = new System.Drawing.Size(82, 28);
            this.addPartMaxTextBox.TabIndex = 8;
            // 
            // addPartMinTextbox
            // 
            this.addPartMinTextbox.Location = new System.Drawing.Point(439, 290);
            this.addPartMinTextbox.Multiline = true;
            this.addPartMinTextbox.Name = "addPartMinTextbox";
            this.addPartMinTextbox.Size = new System.Drawing.Size(82, 28);
            this.addPartMinTextbox.TabIndex = 9;
            // 
            // addPartMachineCompanyTextBox
            // 
            this.addPartMachineCompanyTextBox.Location = new System.Drawing.Point(260, 343);
            this.addPartMachineCompanyTextBox.Multiline = true;
            this.addPartMachineCompanyTextBox.Name = "addPartMachineCompanyTextBox";
            this.addPartMachineCompanyTextBox.Size = new System.Drawing.Size(165, 28);
            this.addPartMachineCompanyTextBox.TabIndex = 10;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(126, 136);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(61, 24);
            this.nameLabel.TabIndex = 11;
            this.nameLabel.Text = "Name";
            this.nameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryLabel.Location = new System.Drawing.Point(101, 186);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(86, 24);
            this.inventoryLabel.TabIndex = 12;
            this.inventoryLabel.Text = "Inventory";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(82, 239);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(105, 24);
            this.priceLabel.TabIndex = 13;
            this.priceLabel.Text = "Price / Cost";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel.Location = new System.Drawing.Point(141, 294);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(46, 24);
            this.maxLabel.TabIndex = 14;
            this.maxLabel.Text = "Max";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel.Location = new System.Drawing.Point(369, 290);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(41, 24);
            this.minLabel.TabIndex = 15;
            this.minLabel.Text = "Min";
            // 
            // machineCompanyLabel
            // 
            this.machineCompanyLabel.AutoSize = true;
            this.machineCompanyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machineCompanyLabel.Location = new System.Drawing.Point(82, 343);
            this.machineCompanyLabel.Name = "machineCompanyLabel";
            this.machineCompanyLabel.Size = new System.Drawing.Size(105, 24);
            this.machineCompanyLabel.TabIndex = 16;
            this.machineCompanyLabel.Text = "Machine ID";
            // 
            // partSaveBtn
            // 
            this.partSaveBtn.Location = new System.Drawing.Point(331, 423);
            this.partSaveBtn.Name = "partSaveBtn";
            this.partSaveBtn.Size = new System.Drawing.Size(84, 40);
            this.partSaveBtn.TabIndex = 17;
            this.partSaveBtn.Text = "Save";
            this.partSaveBtn.UseVisualStyleBackColor = true;
            this.partSaveBtn.Click += new System.EventHandler(this.partSaveBtn_Click);
            // 
            // partCancelBtn
            // 
            this.partCancelBtn.Location = new System.Drawing.Point(439, 423);
            this.partCancelBtn.Name = "partCancelBtn";
            this.partCancelBtn.Size = new System.Drawing.Size(84, 40);
            this.partCancelBtn.TabIndex = 18;
            this.partCancelBtn.Text = "Cancel";
            this.partCancelBtn.UseVisualStyleBackColor = true;
            this.partCancelBtn.Click += new System.EventHandler(this.partCancelBtn_Click);
            // 
            // AddPartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 587);
            this.Controls.Add(this.partCancelBtn);
            this.Controls.Add(this.partSaveBtn);
            this.Controls.Add(this.machineCompanyLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.addPartMachineCompanyTextBox);
            this.Controls.Add(this.addPartMinTextbox);
            this.Controls.Add(this.addPartMaxTextBox);
            this.Controls.Add(this.addPartPriceTextBox);
            this.Controls.Add(this.addPartInventoryTextBox);
            this.Controls.Add(this.addPartNameTextBox);
            this.Controls.Add(this.addPartIDTextBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.inHouseBtn);
            this.Controls.Add(this.addPartLabel);
            this.Name = "AddPartScreen";
            this.Text = "Part";
            this.Load += new System.EventHandler(this.AddPartScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addPartLabel;
        private System.Windows.Forms.RadioButton inHouseBtn;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox addPartIDTextBox;
        private System.Windows.Forms.TextBox addPartNameTextBox;
        private System.Windows.Forms.TextBox addPartInventoryTextBox;
        private System.Windows.Forms.TextBox addPartPriceTextBox;
        private System.Windows.Forms.TextBox addPartMaxTextBox;
        private System.Windows.Forms.TextBox addPartMinTextbox;
        private System.Windows.Forms.TextBox addPartMachineCompanyTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label machineCompanyLabel;
        private System.Windows.Forms.Button partSaveBtn;
        private System.Windows.Forms.Button partCancelBtn;
    }
}