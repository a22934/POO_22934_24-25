using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Data
{
    public static class DataLoader
    {
        // Método genérico para carregar qualquer lista
        public static List<T> LoadFromFile<T>(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                    return new List<T>();

                string json = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<List<T>>(json) ?? new List<T>();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao carregar dados: {ex.Message}");
            }
        }
    }
}