﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Model
{
    public class DishExtra
    {
        public int DishExtraId { get; set; }


        public int DishId { get; set; }
        public Dish Dish { get; set; }

        public int ExtraId { get; set; }
        public Extra Extra { get; set; }

        public int Quantity { get; set; }
        public decimal SubTotal { get; set; }
    }
}
