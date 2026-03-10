namespace Demo_Db.DataLayer;
using Demo_Db.Models;
using Demo_Db.DataSouce;

public class DataOpreations:IDataOperations
{
    private readonly IDummyData _dummyData;

    public DataOpreations(IDummyData dummyData)
    {
        _dummyData = dummyData;
    }

    public IQueryable<User> GetUsers()
    {
        return _dummyData.Users.AsQueryable();
    }

    public IQueryable<string> GetProducts()
    {
        return _dummyData.Products
            .Select(p => p.Product_Name).AsQueryable();
    }

    public IQueryable<OrderInfoDTO> GetOrders()
    {
        return _dummyData.Orders.Join(_dummyData.Users, o => o.UserId, u => u.UserId,
                (o, u) => new { o, u })
            .Join(_dummyData.Products, orderTable => orderTable.o.ProductId, p => p.Product_Id,
                (orderTable, p) => new OrderInfoDTO()
                {
                    OrderId = orderTable.o.UserId,
                    UserId = orderTable.u.UserId,
                    Product_Name = p.Product_Name
                }).AsQueryable();
    }

    public int TotalOrderQuantity()
    {
        return _dummyData.Orders.Select(Q => Q.Quantity).AsQueryable().Sum();
    }

    public decimal TotalOrderAmount()
    {
        return _dummyData.Orders.Select(A => A.Amount).AsQueryable().Sum();
    }
}