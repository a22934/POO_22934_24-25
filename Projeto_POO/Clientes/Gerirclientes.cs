using ClientManagement_OOP;

public class ManageClients
{
    private List<Client> clientList;

    public ManageClients(List<Client> clients)
    {
        clientList = clients;
    }

    // Método para listar os clientes registados
    public void ViewClients()
    {
        Console.WriteLine("\n--- List of Clients ---");

        if (clientList.Count == 0)
        {
            Console.WriteLine("No clients registered.");
        }
        else
        {
            for (int i = 0; i < clientList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {clientList[i]}"); // Exibe o índice junto com o cliente
            }
        }
        Console.WriteLine(); // Linha em branco para espaçamento
    }

    // Método para eliminar um cliente
    public void RemoveClient()
    {
        ViewClients(); // Mostra a lista de clientes para que o usuário escolha

        Console.Write("Enter the number of the client to remove: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= clientList.Count)
        {
            clientList.RemoveAt(index - 1); // Remove o cliente da lista
            Console.WriteLine("Client removed successfully!\n");
        }
        else
        {
            Console.WriteLine("Invalid selection, please try again.");
        }
    }
}
