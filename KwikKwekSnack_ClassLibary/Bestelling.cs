namespace KwikKwekSnack_ClassLibary
{
    public class Bestelling
    {
        private int _id { get; set; }
        private double _totalPrice { get; set; }
        private List <Product> _products;
        private status _status { get; set; }

    public Bestelling(int id)
        {
            _products = new List<Product>();
            _id = id;
        }

        public double GetTotalPrice()
        {
            int price = 0;

            return price;
        }

        enum status
        {
            wachtrij,
            wordtBereid,
            gereed
        }

    }
}