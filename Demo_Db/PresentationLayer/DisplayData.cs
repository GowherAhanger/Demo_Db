using Demo_Db.Models;

namespace Demo_Db.PresentationLayer;
using Demo_Db.ApplicationLayer;
using Demo_Db.DataLayer;

public class DisplayData
{
    private ApplicationService _applicationLayer;
    public DisplayData(ApplicationService applicationLayer)
    {
        _applicationLayer = applicationLayer;
    }

    public void DispalyProductNames()
    {
        var productNames = _applicationLayer.GetProductNames();

        foreach (var product in  productNames)
        {
            Console.WriteLine(product +"      ");
        }
        
    }

    public void DisplayAllOrders()
    {
        var orderList = _applicationLayer.GetAllOrders();
        Console.WriteLine("UserId \t      OredId\t\tProductName");
        foreach (var order in orderList)
        {
          
          Console.WriteLine(order.UserId + "\t\t" + order.OrderId + "\t\t" + order.Product_Name);
        }
    }

    public void DisplayTotalOrderQuantity()
    {
        var totalOrderQuantity = _applicationLayer.getTotalOrderQuantity();
        Console.WriteLine(totalOrderQuantity);
    }

    public void DisplayTotalOrderAmount()
    {
        var totalOrderAmount = _applicationLayer.getTotalOrderAmount();
        Console.WriteLine(totalOrderAmount);
    }

    public void DisplayUsers()
    {
        var users = _applicationLayer.GetAllUsers();
        Console.WriteLine("UserId\t      UserId ");
        foreach (var user in users)
        {
            Console.WriteLine(user.User_Name +" \t\t"+ user.UserId );
        }
    }
    
}