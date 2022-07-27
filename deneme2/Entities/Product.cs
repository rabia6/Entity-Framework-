﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace deneme2.Entities
{
   public class Product
    {
       
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public int ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public Int16 UnitsInStock { get; set; }
        public string QuantityPerUnit { get; set; }

    }
}
