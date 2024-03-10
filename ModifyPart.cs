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

        //Load selected In-House Part
        public ModifyPart(InhousePart inPart)
        {
            InitializeComponent();
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

        private void partSaveBtn_Click(object sender, EventArgs e)
        {

        }

        private void partCancelBtn_Click(object sender, EventArgs e)
        {

        }

        private void inHouseBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
