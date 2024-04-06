using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Samuel_McMasters_C968
{
    class Inventory
    {
        
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();

       


        //Product Methods

        //Add Product to Binding List
        public static void AddProduct(Product prod)
        {
            Products.Add(prod);
        }

        //Remove Product from Binding List
        public static bool RemoveProduct(int prodID)
        {
            bool success = false;

            foreach (Product prod in Products)
            {
                if (prodID == prod.ProductID)
                {
                    Products.Remove(prod);
                    return success = true;
                }
                else
                {
                    MessageBox.Show("ERROR: Could Not Remove Product");
                    return success = false;
                }
            }
            return success;
        }

        //Search Product
        public static Product LookupProduct(int prodID)
        {
            foreach (Product prod in Products)
            {
                if (prod.ProductID == prodID)
                {
                    return prod;
                }
            }
            Product emptyProduct = null;
            return emptyProduct;
        }

        //Update Product
        public static void UpdateProduct(int prodID, Product updatedProduct)
        {
            foreach (Product currentProduct in Products)
            {
                if (currentProduct.ProductID == prodID)
                {
                    currentProduct.Name = updatedProduct.Name;
                    currentProduct.InStock = updatedProduct.InStock;
                    currentProduct.Price = updatedProduct.Price;
                    currentProduct.Max = updatedProduct.Max;
                    currentProduct.Min = updatedProduct.Min;
                    currentProduct.AssociatedParts = updatedProduct.AssociatedParts;
                    return;
                }
            }
        }

        //Part Methods

        //Add Part to binding list
        public static void AddPart(Part part)
        {
            AllParts.Add(part);
        }

        //Remove part from binding list
        public static bool DeletePart(Part part)
        {
            int partID = part.PartID;
            Part deletedPart = LookupPart(partID);
            if (deletedPart == null)
            {
                return false;
            }
            else
            {
                AllParts.Remove(deletedPart);
                return true;
            }
        }

        //Search for Part
        public static Part LookupPart(int partID)
        {
            foreach (Part part in AllParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
                
            }

            Part emptyPart = null;
            return emptyPart;  
        }

        //Update Part
        public static void UpdatePart(int partID, Part updatedPart)
        {
               foreach (Part currentPart in AllParts)
               {
            
                   if (currentPart.PartID == partID)
                   {
                       DeletePart(currentPart);
                       AddPart(updatedPart);
                       return;
                   }
               }
        }
               
               

     


        //Populate Binding Lists with exmaple data
        public static void ExampleItems()
        {
            Product exampleProduct = new Product("Bicycle", 5, 5.00m, 10, 5);
            Products.Add(exampleProduct);

            Part exampleInPart = new InhousePart(0, "Tire", 10, 5.00m, 20, 10, 1001);
            AllParts.Add(exampleInPart);
            Part exampleOutPart = new OutsourcedPart(1, "Seat", 30, 1.00m, 45, 10, "Seat Co.");
            AllParts.Add(exampleOutPart);
        }



    }
}
