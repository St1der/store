﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store1.Models
{
    public class product
    { 
            public int Id { get; set; }
            public string Name { get; set; }
            public int Quantity { get; set; }
            public decimal Price { get; set; }
            public string ImagePath { get; set; }
            public int CategoryId { get; set; }
    }
}
