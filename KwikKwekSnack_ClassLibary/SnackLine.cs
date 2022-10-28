using System;
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
        public List<Extra> Extras { get; set; }

        public SnackLine()
        {
            Extras = new List<Extra>();
        }
    }
}
