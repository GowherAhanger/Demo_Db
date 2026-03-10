using Demo_Db.Models;

namespace Demo_Db.DataLayer;

public interface IDataOperations
{
    IQueryable<User> GetUsers();

    IQueryable<string> GetProducts();

    IQueryable<OrderInfoDTO> GetOrders();

    int TotalOrderQuantity();

    decimal TotalOrderAmount();
}

