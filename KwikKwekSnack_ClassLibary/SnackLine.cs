using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KwikKwekSnack_ClassLibary
{
    public class SnackLine
    {
        [Key()]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Snack Snack { get; set; }
        public List<Extra> Extras { get; set; }
        public decimal Price { get; set; }
        public int amount { get; set; }


        static int lastId = 0;

        public SnackLine()
        {
            Extras = new List<Extra>();
        }
    }
}
