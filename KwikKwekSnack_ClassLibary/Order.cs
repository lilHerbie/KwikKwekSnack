using System.ComponentModel.DataAnnotations;
using KwikKwekSnack_ClassLibary;

namespace KwikKwekSnack_ClassLibary
{
    public class Order
    {
        [Key()]
        public int Id { get; set; }
        public decimal TotalPrice { get; set; }
        public status Status { get; set; }
        public List<DrinkLine> Drinks { get; set; }
        public List<SnackLine> Snacks { get; set; }

        public Order(int id)
        {
            Drinks = new List<DrinkLine>();
            Snacks = new List<SnackLine>();
            Id = id;
    }

        public enum status
    {
        wachtrij,
        wordtBereid,
        gereed
    }

    }
}