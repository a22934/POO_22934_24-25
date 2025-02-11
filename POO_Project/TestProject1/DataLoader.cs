using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace DataTests
{
    [TestClass]
    public class DataLoaderTests
    {
        private string _filePath = "test_data.json";

        [TestCleanup]
        public void Cleanup()
        {
            // Limpa o arquivo de teste após cada teste
            if (File.Exists(_filePath))
            {
                File.Delete(_filePath);
            }
        }

        [TestMethod]
        public void LoadFromFile_WhenFileExists_ShouldReturnList()
        {
            // Arrange
            var expectedData = new List<int> { 1, 2, 3 };
            File.WriteAllText(_filePath, JsonConvert.SerializeObject(expectedData));

            // Act
            var result = DataLoader.LoadFromFile<int>(_filePath);

            // Assert
            CollectionAssert.AreEqual(expectedData, result);
        }

        [TestMethod]
        public void LoadFromFile_WhenFileDoesNotExist_ShouldReturnEmptyList()
        {
            // Arrange
            var expectedData = new List<int>();

            // Act
            var result = DataLoader.LoadFromFile<int>(_filePath);

            // Assert
            CollectionAssert.AreEqual(expectedData, result);
        }

    }
}