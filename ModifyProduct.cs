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
    public partial class ModifyProduct : Form
    {
        BindingList<Part> addedParts = new BindingList<Part>();
        MainScreen MainForm = (MainScreen)Application.OpenForms["MainScreen"];

        public ModifyProduct(Product prod)
        {
            InitializeComponent();
            modProdIDTextBox.Text = prod.ProductID.ToString();
            modProdNameTextBox.Text = prod.Name;
            modProdPriceTextBox.Text = prod.Price.ToString();
            modProdInventoryTextBox.Text = prod.InStock.ToString();
            modProdMaxTextBox.Text = prod.Max.ToString();
            modProdMinTextBox.Text = prod.Min.ToString();



            //Populates top datagridview with all parts
            dgvModifyCandidateParts.DataSource = Inventory.AllParts;

            //Populates bottom datagridview with added parts
            foreach (Part part in prod.AssociatedParts)
            {
                addedParts.Add(part);
            }
            dgvModifyAssociatedParts.DataSource = addedParts;

            //Enables full row select
            dgvModifyCandidateParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvModifyAssociatedParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //Makes Grids Read-Only
            dgvModifyCandidateParts.ReadOnly = true;
            dgvModifyAssociatedParts.ReadOnly = true;

            //Select only one row
            dgvModifyCandidateParts.MultiSelect = false;
            dgvModifyAssociatedParts.MultiSelect = false;

            //Removes Blank Row
            dgvModifyCandidateParts.AllowUserToAddRows = false;
            dgvModifyAssociatedParts.AllowUserToAddRows = false;

        }

        private void ModifyProduct_Load(object sender, EventArgs e)
        {

        }

        //Adds candidate parts to associated parts
        private void candidatePartAddBtn_Click(object sender, EventArgs e)
        {
            Part part = (Part)dgvModifyCandidateParts.CurrentRow.DataBoundItem;
            addedParts.Add(part);
        }


        //Deletes associated parts
        private void partDeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete? This cannot be undone.", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                Part part = (Part)dgvModifyAssociatedParts.CurrentRow.DataBoundItem;
                int id = int.Parse(modProdIDTextBox.Text);

                Product product = Inventory.LookupProduct(id);
                product.RemoveAssociatedPart(part.PartID);

                foreach (DataGridViewRow row in dgvModifyAssociatedParts.SelectedRows)
                {
                    dgvModifyAssociatedParts.Rows.RemoveAt(row.Index);
                }
            }
            else return;
        }

        //Close modify product window 
        private void productCancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void productSaveBtn_Click(object sender, EventArgs e)
        {
            int min;
            int max;
            int inventory;
            decimal price;

            try
            {
                min = int.Parse(modProdMinTextBox.Text);
                max = int.Parse(modProdMaxTextBox.Text);
                inventory = int.Parse(modProdInventoryTextBox.Text);
                price = decimal.Parse(modProdPriceTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Error: Inventory, Price, Max and Min must be numeric values.");
                return;
            }

            int id = int.Parse(modProdIDTextBox.Text);
            string name = modProdNameTextBox.Text;
            inventory = int.Parse(modProdInventoryTextBox.Text);
            price = decimal.Parse(modProdPriceTextBox.Text);
            min = int.Parse(modProdMinTextBox.Text);
            max = int.Parse(modProdMaxTextBox.Text);

            //prevents user from having higher min than max.
            if (min > max)
            {
                MessageBox.Show("Error: min cannot be greater than max");
                return;
            }

            if (inventory > max || inventory < min)
            {
                MessageBox.Show("Error: Inventory must be between max and min inventory");
                return;
            }
            //creates new Product and adds it to inventory with parts
            Product product = new Product(id, name, inventory, price, max, min);
            foreach (Part part in addedParts)
            {
                product.AddAssociatedPart(part);
            }
            Inventory.UpdateProduct(id, product);
            Close();
            MainForm.dgvProducts.Update();
            MainForm.dgvProducts.Refresh();
        }
    }
}
