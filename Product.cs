using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samuel_McMasters_C968
{
    public class Product
    {
        public BindingList<Part> AssociatedParts = new BindingList<Part>();

        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }


        //Blank Constructor 
        public Product() { }

        //Constructor with arguments
        public Product(int prodID, string name, int inventory, decimal price, int max, int min)
        {
            ProductID = prodID;
            Name = name;
            Price = price;
            InStock = inventory;
            Max = max;
            Min = min;
        }

        //Method to add associated parts
        public void AddAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        //Method to remove associated parts
        public bool RemoveAssociatedPart(int partID)
        {
            bool success = false;
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == partID)
                {
                    AssociatedParts.Remove(part);
                    return success = true;
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }

        //Method to search associated parts
        public Part LookupAssociatedPart(int partID)
        {
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            InhousePart emptyInHousePart = new InhousePart();
            return emptyInHousePart;
        }

    }
}
