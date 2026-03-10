namespace Demo_Db.DataSouce;
using Demo_Db.Models;
using System.Collections.Generic;

public class DummyData:IDummyData
{

    
    public List<User> Users { get; } = new List<User>()
    {
        new User { UserId = 1, User_Name = "Ali" },
        new User { UserId = 2, User_Name = "Ayesha" },
        new User { UserId = 3, User_Name = "Ahmed" },
        new User { UserId = 4, User_Name = "Fatima" },
        new User { UserId = 5, User_Name = "Zain" },
        new User { UserId = 6, User_Name = "Sara" },
        new User { UserId = 7, User_Name = "Usman" },
        new User { UserId = 8, User_Name = "Hina" },
        new User { UserId = 9, User_Name = "Bilal" },
        new User { UserId = 10, User_Name = "Noor" },

        new User { UserId = 11, User_Name = "Imran" },
        new User { UserId = 12, User_Name = "Sana" },
        new User { UserId = 13, User_Name = "Kamran" },
        new User { UserId = 14, User_Name = "Anum" },
        new User { UserId = 15, User_Name = "Fahad" },
        new User { UserId = 16, User_Name = "Iqra" },
        new User { UserId = 17, User_Name = "Shahid" },
        new User { UserId = 18, User_Name = "Maryam" },
        new User { UserId = 19, User_Name = "Noman" },
        new User { UserId = 20, User_Name = "Laiba" },

        new User { UserId = 21, User_Name = "Arslan" },
        new User { UserId = 22, User_Name = "Mehak" },
        new User { UserId = 23, User_Name = "Salman" },
        new User { UserId = 24, User_Name = "Bushra" },
        new User { UserId = 25, User_Name = "Hamza" },
        new User { UserId = 26, User_Name = "Areeba" },
        new User { UserId = 27, User_Name = "Danish" },
        new User { UserId = 28, User_Name = "Rimsha" },
        new User { UserId = 29, User_Name = "Saad" },
        new User { UserId = 30, User_Name = "Tania" },

        new User { UserId = 31, User_Name = "Asad" },
        new User { UserId = 32, User_Name = "Maham" },
        new User { UserId = 33, User_Name = "Waqas" },
        new User { UserId = 34, User_Name = "Kiran" },
        new User { UserId = 35, User_Name = "Farhan" },
        new User { UserId = 36, User_Name = "Saba" },
        new User { UserId = 37, User_Name = "Junaid" },
        new User { UserId = 38, User_Name = "Nida" },
        new User { UserId = 39, User_Name = "Talha" },
        new User { UserId = 40, User_Name = "Amna" },

        new User { UserId = 41, User_Name = "Rizwan" },
        new User { UserId = 42, User_Name = "Hafsa" },
        new User { UserId = 43, User_Name = "Adnan" },
        new User { UserId = 44, User_Name = "Komal" },
        new User { UserId = 45, User_Name = "Sheryar" },
        new User { UserId = 46, User_Name = "Mishal" },
        new User { UserId = 47, User_Name = "Omer" },
        new User { UserId = 48, User_Name = "Rabia" },
        new User { UserId = 49, User_Name = "Adeel" },
        new User { UserId = 50, User_Name = "Zoya" }
        
    };

    // 🔹 50 PRODUCTS

    public List<Product> Products { get; } = new()    {
        new Product { Product_Id = 1, Product_Name = "Laptop" },
        new Product { Product_Id = 2, Product_Name = "Mouse" },
        new Product { Product_Id = 3, Product_Name = "Keyboard" },
        new Product { Product_Id = 4, Product_Name = "Monitor" },
        new Product { Product_Id = 5, Product_Name = "Printer" },
        new Product { Product_Id = 6, Product_Name = "Webcam" },
        new Product { Product_Id = 7, Product_Name = "Headphones" },
        new Product { Product_Id = 8, Product_Name = "Microphone" },
        new Product { Product_Id = 9, Product_Name = "USB Hub" },
        new Product { Product_Id = 10, Product_Name = "External HDD" },

        new Product { Product_Id = 11, Product_Name = "SSD" },
        new Product { Product_Id = 12, Product_Name = "RAM" },
        new Product { Product_Id = 13, Product_Name = "Graphics Card" },
        new Product { Product_Id = 14, Product_Name = "Motherboard" },
        new Product { Product_Id = 15, Product_Name = "Power Supply" },
        new Product { Product_Id = 16, Product_Name = "CPU Cooler" },
        new Product { Product_Id = 17, Product_Name = "Router" },
        new Product { Product_Id = 18, Product_Name = "Switch" },
        new Product { Product_Id = 19, Product_Name = "Smartphone" },
        new Product { Product_Id = 20, Product_Name = "Tablet" },

        new Product { Product_Id = 21, Product_Name = "Smartwatch" },
        new Product { Product_Id = 22, Product_Name = "Camera" },
        new Product { Product_Id = 23, Product_Name = "Tripod" },
        new Product { Product_Id = 24, Product_Name = "Power Bank" },
        new Product { Product_Id = 25, Product_Name = "Charger" },
        new Product { Product_Id = 26, Product_Name = "Bluetooth Speaker" },
        new Product { Product_Id = 27, Product_Name = "Earbuds" },
        new Product { Product_Id = 28, Product_Name = "Game Controller" },
        new Product { Product_Id = 29, Product_Name = "VR Headset" },
        new Product { Product_Id = 30, Product_Name = "Docking Station" },

        new Product { Product_Id = 31, Product_Name = "Projector" },
        new Product { Product_Id = 32, Product_Name = "Screen" },
        new Product { Product_Id = 33, Product_Name = "Flash Drive" },
        new Product { Product_Id = 34, Product_Name = "Memory Card" },
        new Product { Product_Id = 35, Product_Name = "UPS" },
        new Product { Product_Id = 36, Product_Name = "Server Rack" },
        new Product { Product_Id = 37, Product_Name = "NAS Storage" },
        new Product { Product_Id = 38, Product_Name = "Ethernet Cable" },
        new Product { Product_Id = 39, Product_Name = "HDMI Cable" },
        new Product { Product_Id = 40, Product_Name = "Laptop Stand" },

        new Product { Product_Id = 41, Product_Name = "Cooling Pad" },
        new Product { Product_Id = 42, Product_Name = "Stylus Pen" },
        new Product { Product_Id = 43, Product_Name = "Barcode Scanner" },
        new Product { Product_Id = 44, Product_Name = "POS Machine" },
        new Product { Product_Id = 45, Product_Name = "Fingerprint Scanner" },
        new Product { Product_Id = 46, Product_Name = "Smart TV" },
        new Product { Product_Id = 47, Product_Name = "Soundbar" },
        new Product { Product_Id = 48, Product_Name = "Drone" },
        new Product { Product_Id = 49, Product_Name = "GPS Tracker" },
        new Product { Product_Id = 50, Product_Name = "IoT Sensor" }
    };

     public List<Order> Orders { get; } = new()
{
    new Order { Id = 1, UserId = 1, ProductId = 1, Quantity = 1, Amount = 100 },
    new Order { Id = 2, UserId = 2, ProductId = 2, Quantity = 2, Amount = 200 },
    new Order { Id = 3, UserId = 3, ProductId = 3, Quantity = 1, Amount = 100 },
    new Order { Id = 4, UserId = 4, ProductId = 4, Quantity = 1, Amount = 100 },
    new Order { Id = 5, UserId = 5, ProductId = 5, Quantity = 3, Amount = 300 },
    new Order { Id = 6, UserId = 6, ProductId = 6, Quantity = 2, Amount = 200 },
    new Order { Id = 7, UserId = 7, ProductId = 7, Quantity = 1, Amount = 100 },
    new Order { Id = 8, UserId = 8, ProductId = 8, Quantity = 2, Amount = 200 },
    new Order { Id = 9, UserId = 9, ProductId = 9, Quantity = 1, Amount = 100 },
    new Order { Id = 10, UserId = 10, ProductId = 10, Quantity = 4, Amount = 400 },

    new Order { Id = 11, UserId = 11, ProductId = 11, Quantity = 2, Amount = 200 },
    new Order { Id = 12, UserId = 12, ProductId = 12, Quantity = 3, Amount = 300 },
    new Order { Id = 13, UserId = 13, ProductId = 13, Quantity = 1, Amount = 100 },
    new Order { Id = 14, UserId = 14, ProductId = 14, Quantity = 5, Amount = 500 },
    new Order { Id = 15, UserId = 15, ProductId = 15, Quantity = 2, Amount = 200 },
    new Order { Id = 16, UserId = 16, ProductId = 16, Quantity = 4, Amount = 400 },
    new Order { Id = 17, UserId = 17, ProductId = 17, Quantity = 1, Amount = 100 },
    new Order { Id = 18, UserId = 18, ProductId = 18, Quantity = 3, Amount = 300 },
    new Order { Id = 19, UserId = 19, ProductId = 19, Quantity = 2, Amount = 200 },
    new Order { Id = 20, UserId = 20, ProductId = 20, Quantity = 5, Amount = 500 },

    new Order { Id = 21, UserId = 21, ProductId = 21, Quantity = 1, Amount = 100 },
    new Order { Id = 22, UserId = 22, ProductId = 22, Quantity = 2, Amount = 200 },
    new Order { Id = 23, UserId = 23, ProductId = 23, Quantity = 4, Amount = 400 },
    new Order { Id = 24, UserId = 24, ProductId = 24, Quantity = 3, Amount = 300 },
    new Order { Id = 25, UserId = 25, ProductId = 25, Quantity = 2, Amount = 200 },
    new Order { Id = 26, UserId = 26, ProductId = 26, Quantity = 1, Amount = 100 },
    new Order { Id = 27, UserId = 27, ProductId = 27, Quantity = 5, Amount = 500 },
    new Order { Id = 28, UserId = 28, ProductId = 28, Quantity = 3, Amount = 300 },
    new Order { Id = 29, UserId = 29, ProductId = 29, Quantity = 2, Amount = 200 },
    new Order { Id = 30, UserId = 30, ProductId = 30, Quantity = 4, Amount = 400 },

    new Order { Id = 31, UserId = 31, ProductId = 31, Quantity = 1, Amount = 100 },
    new Order { Id = 32, UserId = 32, ProductId = 32, Quantity = 3, Amount = 300 },
    new Order { Id = 33, UserId = 33, ProductId = 33, Quantity = 2, Amount = 200 },
    new Order { Id = 34, UserId = 34, ProductId = 34, Quantity = 5, Amount = 500 },
    new Order { Id = 35, UserId = 35, ProductId = 35, Quantity = 4, Amount = 400 },
    new Order { Id = 36, UserId = 36, ProductId = 36, Quantity = 1, Amount = 100 },
    new Order { Id = 37, UserId = 37, ProductId = 37, Quantity = 2, Amount = 200 },
    new Order { Id = 38, UserId = 38, ProductId = 38, Quantity = 3, Amount = 300 },
    new Order { Id = 39, UserId = 39, ProductId = 39, Quantity = 5, Amount = 500 },
    new Order { Id = 40, UserId = 40, ProductId = 40, Quantity = 2, Amount = 200 },

    new Order { Id = 41, UserId = 41, ProductId = 41, Quantity = 4, Amount = 400 },
    new Order { Id = 42, UserId = 42, ProductId = 42, Quantity = 1, Amount = 100 },
    new Order { Id = 43, UserId = 43, ProductId = 43, Quantity = 3, Amount = 300 },
    new Order { Id = 44, UserId = 44, ProductId = 44, Quantity = 2, Amount = 200 },
    new Order { Id = 45, UserId = 45, ProductId = 45, Quantity = 5, Amount = 500 },
    new Order { Id = 46, UserId = 46, ProductId = 46, Quantity = 1, Amount = 100 },
    new Order { Id = 47, UserId = 47, ProductId = 47, Quantity = 4, Amount = 400 },
    new Order { Id = 48, UserId = 48, ProductId = 48, Quantity = 2, Amount = 200 },
    new Order { Id = 49, UserId = 49, ProductId = 49, Quantity = 3, Amount = 300 },
    new Order { Id = 50, UserId = 50, ProductId = 50, Quantity = 5, Amount = 500 }
    };
}
