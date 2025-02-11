using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace Data
{
    public static class DataSaver
    {
        // Método genérico para salvar qualquer lista
        public static void SaveToFile<T>(List<T> data, string filePath)
        {
            try
            {
                string json = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao salvar dados: {ex.Message}");
            }
        }
    }
}