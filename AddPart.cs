﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Samuel_McMasters_C968
{
    public partial class AddPartScreen : Form
    {
        public AddPartScreen()
        {
            InitializeComponent();
            //Loads new part ID 
            addPartIDTextBox.Text = (Inventory.AllParts.Count).ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddPartScreen_Load(object sender, EventArgs e)
        {

        }

        private void inHouseBtn_CheckedChanged(object sender, EventArgs e)
        {
            machineCompanyLabel.Text = "Machine ID";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            machineCompanyLabel.Text = "Company Name";
        }

        //Returns user to main screen
        private void partCancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Saves new part
        private void partSaveBtn_Click(object sender, EventArgs e)
        {
            int partID;
            int minStock;
            int maxStock;
            int inStockInventory;
            decimal price;
            int machineID;

            try
            {
                
                minStock = int.Parse(addPartMinTextbox.Text);
                
            }
            catch
            {
                MessageBox.Show("ERROR: Min level must be numeric.");
                return;
            }

            try
            {
    
                maxStock = int.Parse(addPartMaxTextBox.Text);
               
            }
            catch
            {
                MessageBox.Show("ERROR: Max level must be numeric.");
                return;
            }

            try
            {
                inStockInventory = int.Parse(addPartInventoryTextBox.Text);
            }
            catch
            {
                MessageBox.Show("ERROR: Inventory must be numeric.");
                return;
            }

            try
            {
                price = decimal.Parse(addPartPriceTextBox.Text);
            }
            catch
            {
                MessageBox.Show("ERROR: Price must be numeric.");
                return;
            }

            partID = int.Parse(addPartIDTextBox.Text);
            string name = addPartNameTextBox.Text;
            price = decimal.Parse(addPartPriceTextBox.Text);
            minStock = int.Parse(addPartMinTextbox.Text);
            maxStock = int.Parse(addPartMaxTextBox.Text);
            inStockInventory = int.Parse(addPartInventoryTextBox.Text);


            if (minStock > maxStock)
            {
                MessageBox.Show("ERROR: Max must be greater than min.");
                return;
            }

            if (inStockInventory > maxStock || inStockInventory < minStock)
            {
                MessageBox.Show("ERROR: Inventory must be between max and min values");
                return;
            }



            if (inHouseBtn.Checked)
            {
                try
                {
                    machineID = int.Parse(addPartMachineCompanyTextBox.Text);
                }
                catch
                {
                    MessageBox.Show("ERROR: Machine ID must be numeric.");
                    return;
                }
                machineID = int.Parse(addPartMachineCompanyTextBox.Text);
                InhousePart inPart = new InhousePart(partID, name, inStockInventory, price, maxStock, minStock, machineID);
                Inventory.AddPart(inPart);
            }
            
            if (radioButton1.Checked)
            {
                OutsourcedPart outPart = new OutsourcedPart(partID, name, inStockInventory, price, maxStock, minStock, addPartMachineCompanyTextBox.Text);
                Inventory.AddPart(outPart);
            }
            Close();

        }
    }

}
