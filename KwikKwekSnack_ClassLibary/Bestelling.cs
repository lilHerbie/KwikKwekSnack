namespace KwikKwekSnack_ClassLibary
{
    public class Order
    {
        public int _id { get; set; }
        public double _totalPrice { get; set; }
        public status _status { get; set; }
        public List<DrinkLine> Drinks { get; set; }
        public List<SnackLine> Snacks { get; set; }



        public Order(int id)
        {
            Drinks = new List<DrinkLine>();
            Snacks = new List<SnackLine>();
            _id = id;
        }

        public enum status
        {
            wachtrij,
            wordtBereid,
            gereed
        }

    }
}