﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_CourseWorkBachanGhimire.Models
{
    class ItemRecords:Records
    {
        public ItemRecords(string itemName, string category, double price) : base(itemName, category, price)
        {
            ItemName = itemName;
            Category = category;
            Price = price;
        }      
    }
}
