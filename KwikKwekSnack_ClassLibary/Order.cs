namespace KwikKwekSnack_ClassLibary
{
    public class Order
    {
        public int OrderId { get; set; }
        public double TotalPrice { get; set; }
        public List <Product> Products;
        public Status Status { get; set; }

    /*public Order(int id)
        {
            _products = new List<Product>();
            _id = id;
        }

        public double GetTotalPrice()
        {
            int price = 0;

            return price;
        }
*/
    }

    public enum Status
    {
        wachtrij,
        wordtBereid,
        gereed
    }
}