﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KwikKwekSnack_ClassLibary
{
    public class SnackLine
    {
        [Key()]
        public int Id { get; set; }
        public Snack Snack { get; set; }
        public List<SnackLineHasExta> SnackLineHasExtras { get; set; }
        public decimal Price { get; set; }
        public int amount { get; set; }


        public SnackLine()
        {
            SnackLineHasExtras = new List<SnackLineHasExta>();
        }
    }
}
