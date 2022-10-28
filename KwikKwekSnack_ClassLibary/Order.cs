namespace KwikKwekSnack_ClassLibary
{
    public class Order
    {
        public int Id { get; set; }
        public double TotalPrice { get; set; }
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