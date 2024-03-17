using System;
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
    public partial class ModifyPart : Form
    {


        MainScreen MainForm = (MainScreen)Application.OpenForms["MainScreen"];


        //Load selected In-House Part
        public ModifyPart(InhousePart inPart)
        {
            InitializeComponent();
            inHouseBtn.Checked = true;

            modPartIDTextBox.Text = inPart.PartID.ToString();
            modPartNameTextBox.Text = inPart.Name;
            modPartInventoryTextBox.Text = inPart.InStock.ToString();
            modPartPriceTextBox.Text = inPart.Price.ToString();
            modPartMaxTextBox.Text = inPart.Max.ToString();
            modPartMinTextBox.Text = inPart.Min.ToString();
            modPartMachineCompanyTextBox.Text = inPart.MachineID.ToString();
        }

        //Load Selected Outsourced Part
        public ModifyPart(OutsourcedPart outPart)
        {
            InitializeComponent();
            radioButton1.Checked = true;

            modPartIDTextBox.Text = outPart.PartID.ToString();
            modPartNameTextBox.Text = outPart.Name;
            modPartInventoryTextBox.Text = outPart.InStock.ToString();
            modPartPriceTextBox.Text = outPart.Price.ToString();
            modPartMaxTextBox.Text = outPart.Max.ToString();
            modPartMinTextBox.Text = outPart.Min.ToString();
            modPartMachineCompanyTextBox.Text = outPart.CompanyName;

           
        }

        private void ModifyPart_Load(object sender, EventArgs e)
        {

        }

        //Override selected part and save new data
        private void partSaveBtn_Click(object sender, EventArgs e)
        {
            int min;
            int max;
            int inStock;
            decimal price;

            try
            {
                min = int.Parse(modPartMinTextBox.Text);
                max = int.Parse(modPartMaxTextBox.Text);
                inStock = int.Parse(modPartInventoryTextBox.Text);
                price = decimal.Parse(modPartPriceTextBox.Text);
            }
            catch
            {
                MessageBox.Show("ERROR: Inventory, Price, Max and Min must be numeric values.");
                return;
            }

            //Exception Handling 
            if (min > max)
            {
                MessageBox.Show("ERROR: Max must be greater than min.");
                return;
            }

            if (inStock > max || inStock < min)
            {
                MessageBox.Show("ERROR: Inventory must be between max and min levels.");
                return;
            }

            int id = int.Parse(modPartIDTextBox.Text);
            string name = modPartNameTextBox.Text;
            price = decimal.Parse(modPartPriceTextBox.Text);
            min = int.Parse(modPartMinTextBox.Text);
            max = int.Parse(modPartMaxTextBox.Text);
            inStock = int.Parse(modPartInventoryTextBox.Text);


            

            if (inHouseBtn.Checked)
            {
                InhousePart inPart = new InhousePart(id, name, inStock, price, max, min, int.Parse(modPartMachineCompanyTextBox.Text));
                Inventory.UpdatePart(id, inPart);
                inHouseBtn.Checked = true;
            }
            else
            {
                OutsourcedPart outPart = new OutsourcedPart(id, name, inStock, price, max, min, modPartMachineCompanyTextBox.Text);
                Inventory.UpdatePart(id, outPart);
                radioButton1.Checked = true;
            }
            Close();
            MainForm.dgvParts.Update();
            MainForm.dgvParts.Refresh();



        }

        private void partCancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Changes text to "Machine ID"
        private void inHouseBtn_CheckedChanged(object sender, EventArgs e)
        {
            machineCompanyLabel.Text = "Machine ID";
        }


        //Changes text to "Company Name"
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            machineCompanyLabel.Text = "Company Name";
        }
    }
}
