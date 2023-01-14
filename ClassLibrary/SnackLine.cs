using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class SnackLine
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Snack Snack { get; set; }
        [ForeignKey("Snack")]
        public int SnackId { get; set; }
        [NotMapped]
        public string SnackName { get; set; }
        public int Amount { get; set; }
        public List<ExtraLine> ExtraLines { get; set; }
        [DataType(DataType.Currency)]
        [NotMapped]
        public float TotalPrice
        {
            get
            {
                if(Snack != null)
                {
                    float totalPrice = Snack.Price;
                    foreach (ExtraLine extraLine in ExtraLines)
                    {
                        totalPrice += extraLine.Extra.Price;
                    }
                    return totalPrice;
                }
                return 0;
            }
            set
            {

            }
        }

        public SnackLine()
        {
            ExtraLines = new List<ExtraLine>();

        }
        
    }
}
