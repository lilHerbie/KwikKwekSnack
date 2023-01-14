using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class DrinkLine
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Drink Drink { get; set; }
        [NotMapped]
        public string DrinkName { get; set; }
        public int DrinkId { get; set; }
        public bool HasStraw { get; set; }
        public bool HasIce { get; set; }
        public int Amount { get; set; }
        public Size Size { get; set; }
        [DataType(DataType.Currency)]
        [NotMapped]
        public float TotalPrice
        {
            get
            {
                if (Drink != null)
                {

                    float totalPrice = Drink.Price;
                    if (Size == Size.M)
                    {
                        totalPrice = totalPrice * 1.25f;
                    }
                    else if (Size == Size.L)
                    {
                        totalPrice = totalPrice * 1.50f;
                    }
                    else if (Size == Size.XL)
                    {
                        totalPrice = totalPrice * 1.75f;
                    }
                    if (HasIce) { totalPrice += 0.15f; }
                    if (HasStraw) { totalPrice += 0.10f; }
                    return totalPrice;
                }
                return 0;
            }
            set
            {

            }
            


        }
    }
    public enum Size
    {
        S,
        M,
        L,
        XL
    }
}
    



