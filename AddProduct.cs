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
    public partial class AddProduct : Form
    {
        BindingList<Part> addedParts = new BindingList<Part>();
        public AddProduct()
        {
            InitializeComponent();

            //Populates top datagridview with all parts
            dgvCandidateParts.DataSource = Inventory.AllParts;

            //Populates bottom datagridview with added parts
            dgvAssociatedParts.DataSource = addedParts;

            //Enables full row select
            dgvCandidateParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAssociatedParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //Makes Grids Read-Only
            dgvCandidateParts.ReadOnly = true;
            dgvAssociatedParts.ReadOnly = true;

            //Select only one row
            dgvCandidateParts.MultiSelect = false;
            dgvAssociatedParts.MultiSelect = false;

            //Removes Blank Row
            dgvCandidateParts.AllowUserToAddRows = false;
            dgvAssociatedParts.AllowUserToAddRows = false;



        }

        //Removes auto-selected row from datagridview
        private void bindingComplete(object sender, DataGridViewCellEventArgs e)
        {
            dgvCandidateParts.ClearSelection();
            dgvAssociatedParts.ClearSelection();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }

        //Adds Candidate part to associated part grid view
        private void candidatePartAddBtn_Click(object sender, EventArgs e)
        {
            Part addedPart = (Part)dgvCandidateParts.CurrentRow.DataBoundItem;
            addedParts.Add(addedPart);
        }


        //Deletes associated part 
        private void partDeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete? This cannot be undone.", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                foreach (DataGridViewRow row in dgvAssociatedParts.SelectedRows)
                {
                    dgvAssociatedParts.Rows.RemoveAt(row.Index);
                }
            }
            else return;
        }


        //Closes product window
        private void productCancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Searched for candidate part
        private void candidatePartSearchBtn_Click(object sender, EventArgs e)
        {
            int partID = int.Parse(candidatePartSearchBox.Text);
            Part match = Inventory.LookupPart(partID);
            foreach (DataGridViewRow row in dgvCandidateParts.Rows)
            {
                Part part = (Part)row.DataBoundItem;
                if (part.PartID == match.PartID)
                {
                    row.Selected = true;
                    break;
                }
                else
                {
                    row.Selected = false;
                }
            }
        }


        //Save new product 
        private void productSaveBtn_Click(object sender, EventArgs e)
        {
            int inventory;
            int min;
            int max;
            decimal price;

            try
            {
                min = int.Parse(addProductMinTextBox.Text);
                max = int.Parse(addProductMaxTextBox.Text);
                inventory = int.Parse(addProductInventoryTextBox.Text);
                price = decimal.Parse(addProductPriceTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Error: Inventory, Price, Max and Min text fields must be numeric values.");
                return;
            }

            string name = addProductNameTextBox.Text;
            inventory = int.Parse(addProductInventoryTextBox.Text);
            price = decimal.Parse(addProductPriceTextBox.Text);
            min = int.Parse(addProductMinTextBox.Text);
            max = int.Parse(addProductMaxTextBox.Text);

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
            //creates new Product and adds it to inventory
            Product product = new Product((Inventory.Products.Count + 1), name, inventory, price, max, min);
            Inventory.AddProduct(product);

            foreach (Part part in addedParts)
            {
                product.AddAssociatedPart(part);
            }
            Close();
        }
    }
}
