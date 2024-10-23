using System;

namespace ClientManagement_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            ManageClients clientManagement = new ManageClients(); // Instance of the ManageClients class
            int option;

            // Main menu
            do
            {
                Console.WriteLine("=== Client Management ===");
                Console.WriteLine("1. Add Client");
                Console.WriteLine("2. View Registered Clients");
                Console.WriteLine("0. Exit");
                Console.Write("Choose an option: ");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        clientManagement.AddClient(); // Method from the ManageClients class
                        break;
                    case 2:
                        clientManagement.ViewClients(); // Method from the ManageClients class
                        break;
                    case 0:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            } while (option != 0);
        }
    }
}
