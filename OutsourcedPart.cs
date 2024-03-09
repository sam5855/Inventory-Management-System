﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samuel_McMasters_C968
{
    public class OutsourcedPart : Part
    {
        public string CompanyName { get; set; }

        public OutsourcedPart(int partID, string name, decimal price, int inStock, int min, int max, string companyName)
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
