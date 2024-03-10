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
        public static Product LookupProduct (int prodID)
        {
            foreach (Product prod in Products)
            {
                if (prod.ProductID == prodID)
                {
                    return prod;
                }
            }
            Product emptyProduct = new Product();
            return emptyProduct;
        }

        //Update Product
        public static void UpdateProduct (int prodID, Product updatedProduct)
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
        public static Product CurrentProduct { get; set; }
        public static int CurrentProductID { get; set; }
        public static int CurrentProductIndex { get; set; }






        //Part Methods

        //Add Part to binding list
        public static void AddPart(Part part)
        {
            AllParts.Add(part);
        }

        //Remove part from binding list
        public static bool DeletePart(Part part)
        {
            try
            {
                AllParts.Remove(part);
                return true;
            }
            catch
            {
                return false;
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
            
          //  AllParts.RemoveAt(partID - 1);
          //  AddPart(updatedPart);

            //int partIDHolder = partID;   

               foreach (Part currentPart in AllParts)
               {
                  if (currentPart.PartID == partID)
                  {
                       currentPart.Name = updatedPart.Name;
                       currentPart.InStock = updatedPart.InStock;  
                       currentPart.Price = updatedPart.Price;
                       currentPart.Max = updatedPart.Max;
                       currentPart.Min = updatedPart.Min;
                      return;
                   }
               }
               
               

        }


        //Populate Binding Lists with exmaple data
        public static void ExampleItems()
        {
            Product exampleProduct = new Product("Example Product", 5, 5.0m, 10, 5);
            Products.Add(exampleProduct);

            Part exampleInPart = new InhousePart("Example In-Part", 10, 5.0m, 20, 10, 1001);
            AllParts.Add(exampleInPart);
            Part exampleOutPart = new OutsourcedPart("Example Out-Part", 30, 1.0m, 45, 10, "Test Company");
            AllParts.Add(exampleOutPart);
        }


    }
}
