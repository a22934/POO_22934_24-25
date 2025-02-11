using Microsoft.VisualStudio.TestTools.UnitTesting;
using Controllers;
using Models;
using System.IO;

[TestClass]
public class ClientControllerTests
{
    private string _filePath = "test_clients.json";

    [TestInitialize]
    public void Setup()
    {
        // Limpa o arquivo de teste antes de cada teste
        if (File.Exists(_filePath))
        {
            File.Delete(_filePath);
        }
    }
    
    [TestMethod]
    public void RegisterClient_ValidInput_ReturnsSuccess()
    {
        // Arrange
        var controller = new ClientController(_filePath);

        // Act
        var result = controller.RegisterClient(
            name: "João Silva",
            nif: "123456789",
            contact: "912345678",
            password: "password123"
        );

        // Assert
        Assert.IsTrue(result.success);
        Assert.AreEqual("Cliente registrado com sucesso", result.message);
    }

    [TestMethod]
    
    public void RegisterClient_DuplicateNIF_ReturnsFailure()
    {
        // Arrange
        var controller = new ClientController(_filePath);
        controller.RegisterClient("João Silva", "123456789", "912345678", "password123");

        // Act
        var result = controller.RegisterClient(
            name: "Maria Santos",
            nif: "123456789", // NIF duplicado
            contact: "923456789",
            password: "password456"
        );

        // Assert
        Assert.IsFalse(result.success);
        Assert.AreEqual("NIF já registrado", result.message);
    }
}