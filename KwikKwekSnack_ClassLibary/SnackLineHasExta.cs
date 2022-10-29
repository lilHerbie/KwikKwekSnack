using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KwikKwekSnack_ClassLibary
{
    public class SnackLineHasExta
    {
        [Key()]
        public int Id { get; set; }
        public int amount { get; set; }

    }
}
