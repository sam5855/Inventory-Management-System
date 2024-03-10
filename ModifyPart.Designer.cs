namespace Samuel_McMasters_C968
{
    partial class ModifyPart
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
            this.modifyPartLabel = new System.Windows.Forms.Label();
            this.inHouseBtn = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.partCancelBtn = new System.Windows.Forms.Button();
            this.partSaveBtn = new System.Windows.Forms.Button();
            this.machineCompanyLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.modPartMachineCompanyTextBox = new System.Windows.Forms.TextBox();
            this.modPartMinTextBox = new System.Windows.Forms.TextBox();
            this.modPartMaxTextBox = new System.Windows.Forms.TextBox();
            this.modPartPriceTextBox = new System.Windows.Forms.TextBox();
            this.modPartInventoryTextBox = new System.Windows.Forms.TextBox();
            this.modPartNameTextBox = new System.Windows.Forms.TextBox();
            this.modPartIDTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // modifyPartLabel
            // 
            this.modifyPartLabel.AutoSize = true;
            this.modifyPartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPartLabel.Location = new System.Drawing.Point(12, 9);
            this.modifyPartLabel.Name = "modifyPartLabel";
            this.modifyPartLabel.Size = new System.Drawing.Size(121, 25);
            this.modifyPartLabel.TabIndex = 1;
            this.modifyPartLabel.Text = "Modify Part";
            // 
            // inHouseBtn
            // 
            this.inHouseBtn.AutoSize = true;
            this.inHouseBtn.Checked = true;
            this.inHouseBtn.Location = new System.Drawing.Point(187, 17);
            this.inHouseBtn.Name = "inHouseBtn";
            this.inHouseBtn.Size = new System.Drawing.Size(68, 17);
            this.inHouseBtn.TabIndex = 2;
            this.inHouseBtn.TabStop = true;
            this.inHouseBtn.Text = "In-House";
            this.inHouseBtn.UseVisualStyleBackColor = true;
            this.inHouseBtn.CheckedChanged += new System.EventHandler(this.inHouseBtn_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(285, 17);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(80, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.Text = "Outsourced";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // partCancelBtn
            // 
            this.partCancelBtn.Location = new System.Drawing.Point(421, 439);
            this.partCancelBtn.Name = "partCancelBtn";
            this.partCancelBtn.Size = new System.Drawing.Size(84, 40);
            this.partCancelBtn.TabIndex = 34;
            this.partCancelBtn.Text = "Cancel";
            this.partCancelBtn.UseVisualStyleBackColor = true;
            this.partCancelBtn.Click += new System.EventHandler(this.partCancelBtn_Click);
            // 
            // partSaveBtn
            // 
            this.partSaveBtn.Location = new System.Drawing.Point(313, 439);
            this.partSaveBtn.Name = "partSaveBtn";
            this.partSaveBtn.Size = new System.Drawing.Size(84, 40);
            this.partSaveBtn.TabIndex = 33;
            this.partSaveBtn.Text = "Save";
            this.partSaveBtn.UseVisualStyleBackColor = true;
            this.partSaveBtn.Click += new System.EventHandler(this.partSaveBtn_Click);
            // 
            // machineCompanyLabel
            // 
            this.machineCompanyLabel.AutoSize = true;
            this.machineCompanyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machineCompanyLabel.Location = new System.Drawing.Point(64, 359);
            this.machineCompanyLabel.Name = "machineCompanyLabel";
            this.machineCompanyLabel.Size = new System.Drawing.Size(105, 24);
            this.machineCompanyLabel.TabIndex = 32;
            this.machineCompanyLabel.Text = "Machine ID";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel.Location = new System.Drawing.Point(341, 306);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(41, 24);
            this.minLabel.TabIndex = 31;
            this.minLabel.Text = "Min";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel.Location = new System.Drawing.Point(123, 306);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(46, 24);
            this.maxLabel.TabIndex = 30;
            this.maxLabel.Text = "Max";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(64, 255);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(105, 24);
            this.priceLabel.TabIndex = 29;
            this.priceLabel.Text = "Price / Cost";
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryLabel.Location = new System.Drawing.Point(83, 202);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(86, 24);
            this.inventoryLabel.TabIndex = 28;
            this.inventoryLabel.Text = "Inventory";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(108, 152);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(61, 24);
            this.nameLabel.TabIndex = 27;
            this.nameLabel.Text = "Name";
            // 
            // modPartMachineCompanyTextBox
            // 
            this.modPartMachineCompanyTextBox.Location = new System.Drawing.Point(232, 359);
            this.modPartMachineCompanyTextBox.Multiline = true;
            this.modPartMachineCompanyTextBox.Name = "modPartMachineCompanyTextBox";
            this.modPartMachineCompanyTextBox.Size = new System.Drawing.Size(165, 28);
            this.modPartMachineCompanyTextBox.TabIndex = 26;
            // 
            // modPartMinTextBox
            // 
            this.modPartMinTextBox.Location = new System.Drawing.Point(411, 306);
            this.modPartMinTextBox.Multiline = true;
            this.modPartMinTextBox.Name = "modPartMinTextBox";
            this.modPartMinTextBox.Size = new System.Drawing.Size(82, 28);
            this.modPartMinTextBox.TabIndex = 25;
            // 
            // modPartMaxTextBox
            // 
            this.modPartMaxTextBox.Location = new System.Drawing.Point(232, 306);
            this.modPartMaxTextBox.Multiline = true;
            this.modPartMaxTextBox.Name = "modPartMaxTextBox";
            this.modPartMaxTextBox.Size = new System.Drawing.Size(82, 28);
            this.modPartMaxTextBox.TabIndex = 24;
            // 
            // modPartPriceTextBox
            // 
            this.modPartPriceTextBox.Location = new System.Drawing.Point(232, 255);
            this.modPartPriceTextBox.Multiline = true;
            this.modPartPriceTextBox.Name = "modPartPriceTextBox";
            this.modPartPriceTextBox.Size = new System.Drawing.Size(165, 28);
            this.modPartPriceTextBox.TabIndex = 23;
            // 
            // modPartInventoryTextBox
            // 
            this.modPartInventoryTextBox.Location = new System.Drawing.Point(232, 202);
            this.modPartInventoryTextBox.Multiline = true;
            this.modPartInventoryTextBox.Name = "modPartInventoryTextBox";
            this.modPartInventoryTextBox.Size = new System.Drawing.Size(165, 28);
            this.modPartInventoryTextBox.TabIndex = 22;
            // 
            // modPartNameTextBox
            // 
            this.modPartNameTextBox.Location = new System.Drawing.Point(232, 152);
            this.modPartNameTextBox.Multiline = true;
            this.modPartNameTextBox.Name = "modPartNameTextBox";
            this.modPartNameTextBox.Size = new System.Drawing.Size(165, 28);
            this.modPartNameTextBox.TabIndex = 21;
            // 
            // modPartIDTextBox
            // 
            this.modPartIDTextBox.Location = new System.Drawing.Point(232, 107);
            this.modPartIDTextBox.Multiline = true;
            this.modPartIDTextBox.Name = "modPartIDTextBox";
            this.modPartIDTextBox.Size = new System.Drawing.Size(165, 28);
            this.modPartIDTextBox.TabIndex = 20;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(142, 107);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(27, 24);
            this.idLabel.TabIndex = 19;
            this.idLabel.Text = "ID";
            // 
            // ModifyPart
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
            this.Controls.Add(this.modPartMachineCompanyTextBox);
            this.Controls.Add(this.modPartMinTextBox);
            this.Controls.Add(this.modPartMaxTextBox);
            this.Controls.Add(this.modPartPriceTextBox);
            this.Controls.Add(this.modPartInventoryTextBox);
            this.Controls.Add(this.modPartNameTextBox);
            this.Controls.Add(this.modPartIDTextBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.inHouseBtn);
            this.Controls.Add(this.modifyPartLabel);
            this.Name = "ModifyPart";
            this.Text = "ModifyPart";
            this.Load += new System.EventHandler(this.ModifyPart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label modifyPartLabel;
        private System.Windows.Forms.RadioButton inHouseBtn;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button partCancelBtn;
        private System.Windows.Forms.Button partSaveBtn;
        private System.Windows.Forms.Label machineCompanyLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox modPartMachineCompanyTextBox;
        private System.Windows.Forms.TextBox modPartMinTextBox;
        private System.Windows.Forms.TextBox modPartMaxTextBox;
        private System.Windows.Forms.TextBox modPartPriceTextBox;
        private System.Windows.Forms.TextBox modPartInventoryTextBox;
        private System.Windows.Forms.TextBox modPartNameTextBox;
        private System.Windows.Forms.TextBox modPartIDTextBox;
        private System.Windows.Forms.Label idLabel;
    }
}