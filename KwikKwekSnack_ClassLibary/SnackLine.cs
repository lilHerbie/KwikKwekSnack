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
        public double Price { get; set; }

        static int lastId = 0;

        public SnackLine()
        {
            Extras = new List<Extra>();
            Id = Interlocked.Increment(ref lastId);
        }
    }
}
