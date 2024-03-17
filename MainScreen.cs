using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Samuel_McMasters_C968
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();

            //Method to load example parts and products
            Inventory.ExampleItems();

            //Load data grids with data

            dgvParts.DataSource = Inventory.AllParts;
            dgvProducts.DataSource = Inventory.Products;

            //Enables full row select
            dgvParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //Makes Grids Read-Only
            dgvParts.ReadOnly = true;
            dgvProducts.ReadOnly = true;

            //Select only one row
            dgvParts.MultiSelect = false;
            dgvProducts.MultiSelect = false;

            //Removes Blank Row
            dgvParts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToAddRows = false;
            


        }




        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        //Part side events
        //Opens Add Part Screen
        private void addPartBtn_Click(object sender, EventArgs e)
        {
            new AddPartScreen().ShowDialog();
        }

        //Opens Modify Part Screen
        private void modifyPartBtn_Click(object sender, EventArgs e)
        {
            //Checks if selected item is In-House or Outsourced 
            if (dgvParts.CurrentRow.DataBoundItem.GetType() == typeof(Samuel_McMasters_C968.InhousePart))
            {
                InhousePart inHousePart = (InhousePart)dgvParts.CurrentRow.DataBoundItem;
                new ModifyPart(inHousePart).ShowDialog();
            }
            else
            {
                OutsourcedPart outsourcedPart = (OutsourcedPart)dgvParts.CurrentRow.DataBoundItem;
                new ModifyPart(outsourcedPart).ShowDialog();
            }
        }

        //Deletes Selected Part
        private void deletePartBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete part? This cannot be undone","Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                //Checks if part is an associated part
                Part toDelete = (Part)dgvParts.CurrentRow.DataBoundItem;
                foreach (Product prod in Inventory.Products)
                {
                    foreach (Part tryDelete in prod.AssociatedParts)
                    {
                        if (toDelete.PartID == tryDelete.PartID)
                        {
                            MessageBox.Show("Cannot delete part. Part is associated with product.");
                            return;
                        }
                        

                    } 
                }
                foreach (DataGridViewRow row in dgvParts.SelectedRows)
                {
                    dgvParts.Rows.RemoveAt(row.Index);
                    return;
                }
            }
            else return;
        }

        //Searched for entered part
        private void partsSearchBtn_Click(object sender, EventArgs e)
        {
            //Exception handling if search box is empty
            try
            {
                int srchValue = int.Parse(partSearchBox.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a valid Part ID to search.");
                dgvParts.ClearSelection();
                partSearchBox.Text = null;
                return;
            }

            int searchValue = int.Parse(partSearchBox.Text);
            if (searchValue < 0) return;

            Part match = Inventory.LookupPart(int.Parse(partSearchBox.Text));

            //Exception handling if search value is not in table
            if (match == null)
            {
                MessageBox.Show("Could not locate part.");
                partSearchBox.Text = null;
                return;
            }

            foreach (DataGridViewRow row in dgvParts.Rows)
            {
                Part part = (Part)row.DataBoundItem;
                if(part.PartID == match.PartID)
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




        //Product Side Events
        //Add product button
        private void addProductBtn_Click(object sender, EventArgs e)
        {
            new AddProduct().ShowDialog();
        }


        //Modify product button 
        private void modifyProductBtn_Click(object sender, EventArgs e)
        {
            Product selectedProd = (Product)dgvProducts.CurrentRow.DataBoundItem;
            new ModifyProduct(selectedProd).ShowDialog();
        }


        //Delete Product button
        private void deleteProductBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete? This cannot be undone.", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Product product = (Product)dgvProducts.CurrentRow.DataBoundItem;
                if (product.AssociatedParts.Count > 0)
                {
                    MessageBox.Show("Cannot delete product with associated parts. Please remove parts attached to this product.");
                    return;
                }
                foreach (DataGridViewRow row in dgvProducts.SelectedRows)
                {
                    dgvProducts.Rows.RemoveAt(row.Index);
                }

            }
            else return;        
        }

        //Searches for product
        private void productSearchBtn_Click(object sender, EventArgs e)
        {
            //Exception handling if search box is empty or doesn't contain ID
            try
            {
                int srchValue = int.Parse(productSearchBox.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a valid Product ID to search.");
                dgvProducts.ClearSelection();
                productSearchBox.Text = null;
                return;
            }

            int searchValue = int.Parse(productSearchBox.Text);
            if (searchValue < 0) return;

            Product match = Inventory.LookupProduct(int.Parse(productSearchBox.Text));
            if ( match == null)
            {
                MessageBox.Show("Could not locate product.");
                productSearchBox.Text = null;
                return;
            }

            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                Product product = (Product)row.DataBoundItem;
                if (product.ProductID == match.ProductID)
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


        private void dgvParts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        //Removes auto-selected row upon running
        private void myBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvParts.ClearSelection();
            dgvProducts.ClearSelection();
        }


        //Close App
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

        }

        
    }
}
