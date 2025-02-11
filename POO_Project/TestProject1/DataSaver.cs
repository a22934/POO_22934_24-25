using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace DataTests
{
    [TestClass]
    public class DataSaverTests
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
        public void SaveToFile_ShouldSaveDataToFile()
        {
            // Arrange
            var data = new List<string> { "test1", "test2", "test3" };

            // Act
            DataSaver.SaveToFile(data, _filePath);

            // Assert
            Assert.IsTrue(File.Exists(_filePath));
            var fileContent = File.ReadAllText(_filePath);
            var deserializedData = JsonConvert.DeserializeObject<List<string>>(fileContent);
            CollectionAssert.AreEqual(data, deserializedData);
        } 
    }
}