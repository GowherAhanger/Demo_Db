using System.Collections;
using Demo_Db.DataLayer;
using Demo_Db.Models;

namespace Demo_Db.ApplicationLayer;

public class ApplicationService:IApplicationService
{
   private readonly IDataOperations _dataOpp;

public ApplicationService(IDataOperations dataOpp)
{
    _dataOpp = dataOpp;
}
    //Get All Products.............................................
    public IEnumerable<string> GetProductNames()
    {
        return _dataOpp.GetProducts();

    }
   //Get All orders................................................
   public IEnumerable<OrderInfoDTO> GetAllOrders()
   {
       return _dataOpp.GetOrders();
   }
//get order Quantity...........................................................
   public int getTotalOrderQuantity()
   {
       return _dataOpp.TotalOrderQuantity();
   }
   //get order amount................................................
   public decimal getTotalOrderAmount()
   {
       return _dataOpp.TotalOrderAmount();
   }

   public IEnumerable<User> GetAllUsers()
   {
       return _dataOpp.GetUsers();
   }
   
}