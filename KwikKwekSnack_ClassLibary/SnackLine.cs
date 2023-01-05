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
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("SnackId")]
        public int SnackId { get; set; }
        //public Snack Snack { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        //public List<Extra> Extras { get; set; }
        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
        public int amount { get; set; }

        public SnackLine()
        {
            //Extras = new List<Extra>();
        }
    }
}
