﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KwikKwekSnack_ClassLibary
{
    public class DrinkLine
    {
        public bool HasStraw { get; set; }
        public bool HasIce { get; set; }
        public int Id { get; set; }
        public Size Size { get; set; }
        public Drink Drink { get; set; }
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        public int amount { get; set; }
    }

    public enum Size
    {
        S,
        M,
        L,
        XL
    }
}
