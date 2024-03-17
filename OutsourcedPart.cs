using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samuel_McMasters_C968
{
    public class OutsourcedPart : Part
    {
        public string CompanyName { get; set; }


        public OutsourcedPart() { }

        //Constructor for Add Part Functionality 
        public OutsourcedPart(string name, int inStock, decimal price, int max, int min, string companyName)
        {
            PartID = (Inventory.AllParts.Count);
            Name = name;    
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
            CompanyName = companyName;
        }

        //Constructor for Modify Part Functionality
        public OutsourcedPart(int partID, string name, int inStock, decimal price, int max, int min, string companyName)
        {
            PartID = partID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
            CompanyName = companyName;
        }

    }
}
