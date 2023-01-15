using ClassLibrary;
using ConsoleApp;

public class Program
{
    static void Main(string[] args)
    {

        Repository _repo = new Repository();
        MainController _mainController = new MainController(_repo);

        _mainController.PrintStartup();
        _mainController.ShowOrders();
        _mainController.Start();

    }
}
