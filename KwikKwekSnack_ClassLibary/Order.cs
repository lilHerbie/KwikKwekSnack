namespace KwikKwekSnack_ClassLibary
{
    public class Order
    {
        private int OrderId { get; set; }
        private double TotalPrice { get; set; }
        private List <Product> Products;
        private Status Status { get; set; }

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