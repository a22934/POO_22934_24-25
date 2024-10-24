using ClientManagement_OOP;

public class ClientesMenu
{
    private List<Client> clientList;
    private ManageClients clientManagement;

    public ClientesMenu(List<Client> clients)
    {
        clientList = clients;
        clientManagement = new ManageClients(clientList);
    }

    public void ShowMenu()
    {
        int option;
        do
        {
            Console.WriteLine("\n=== Clientes ===");
            Console.WriteLine("1. View Registered Clients");
            Console.WriteLine("2. Remove Client");
            Console.WriteLine("0. Back to Main Menu");
            Console.Write("Choose an option: ");

            if (!int.TryParse(Console.ReadLine(), out option))
            {
                Console.WriteLine("Invalid input, please enter a number.");
                continue;
            }

            switch (option)
            {
                case 1:
                    clientManagement.ViewClients(); // Chama o método para visualizar clientes
                    break;
                case 2:
                    clientManagement.RemoveClient(); // Chama o método para remover cliente
                    break;
                case 0:
                    break; // Volta ao menu principal
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        } while (option != 0);
    }
}
