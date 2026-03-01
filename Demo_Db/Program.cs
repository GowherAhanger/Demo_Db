using Demo_Db.ApplicationLayer;
using Demo_Db.DataLayer;
using Demo_Db.PresentationLayer;
using Demo_Db.ApplicationLayer;
using Demo_Db.DataSouce;
using Demo_Db.PresentationLayer;

namespace Demo_Db;

class Program
{


    static void Main(string[] args)
    {

        
        bool start = true;
        DataOpreations dataOperations = new DataOpreations();
        ApplicationService ap = new ApplicationService(dataOperations);
        DisplayData DD = new DisplayData(ap);

        while (start)
        {
            
            Console.WriteLine("1. Display Products");
            Console.WriteLine("2. Display All Orders");
            Console.WriteLine("3. Display Total Order Quantity");
            Console.WriteLine("4. Display Total Order Amount");
            Console.WriteLine("5. Display All Users");
            Console.WriteLine("6. Exit Demo_Db");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("\n----------------Displaying Products------------------------\n");
                    DD.DispalyProductNames();
                    break;
                case "2":
                    Console.WriteLine("\n\n--------------Displaying All Orders------------------- \n");
                    DD.DisplayAllOrders();
                    break;
                case "3":
                    Console.WriteLine("\n\n---------------Total Order Quantity --------------------");
                    DD.DisplayTotalOrderQuantity();
                    break;
                case "4":
                    Console.WriteLine("\n\n--------------- Total Order Amount ----------------------");
                    DD.DisplayTotalOrderAmount();
                    break;
                case "5":
                   Console.WriteLine("\n ---------------------------Display All Users ----------------");
                    DD.DisplayUsers();
                    break;
                case "6":
                    start = false;
                    Console.WriteLine("Exiting Demo_Db...");
                    break;
                
            }
        }
    }
}