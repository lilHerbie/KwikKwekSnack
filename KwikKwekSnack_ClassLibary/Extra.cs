using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KwikKwekSnack_ClassLibary
{
    public class Extra
    {
        [Key()]
        public int Id { get; set; }
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        public string Name { get; set; }
        public List<SnackLine> SnackLines { get; set; }

        public Extra(){
            SnackLines = new List<SnackLine>();
        }
    }

}
