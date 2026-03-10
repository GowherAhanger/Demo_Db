namespace Demo_Db.DataSouce;

using Demo_Db.Models;
using System.Collections.Generic;

public interface IDummyData
{
    List<User> Users { get; }
    List<Product> Products { get; }
    List<Order> Orders { get; }
}