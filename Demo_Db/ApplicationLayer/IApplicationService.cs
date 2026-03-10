using Demo_Db.Models;

namespace Demo_Db.ApplicationLayer;

public interface IApplicationService
{
    IEnumerable<string> GetProductNames();

        IEnumerable<OrderInfoDTO> GetAllOrders();

        int getTotalOrderQuantity();

        decimal getTotalOrderAmount();

    IEnumerable<User> GetAllUsers();
}