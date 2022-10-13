namespace KwikKwekSnack_ClassLibary
{
    public class Order
    {
        public int OrderId { get; set; }
        public double TotalPrice { get; set; }
        public List<Snack> Snack { get; set; }
        public List<Drink> Drink { get; set; }
        public Status Status { get; set; }

    }

    public enum Status
    {
        wachtrij,
        wordtBereid,
        gereed
    }
}