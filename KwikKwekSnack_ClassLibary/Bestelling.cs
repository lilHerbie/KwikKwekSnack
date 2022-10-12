namespace KwikKwekSnack_ClassLibary
{
    public class Bestelling
    {
        private int _id { get; set; }
        private int totalPrice { get; set; }
        private List <Product> products;
        
        public Bestelling(int id)
        {
            products = new List<Product>();
            _id = id;
        }

    }
}