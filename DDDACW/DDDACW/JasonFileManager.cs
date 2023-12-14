using System;
using System.IO;
using System.Text.Json;

namespace DDDACW
{
    public class JsonFileManager
    {
        // Write JSON data to a file
        public static void WriteToJsonFile<T>(string filePath, T data)
        {
            try
            {
                string jsonData = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, jsonData);
                //Console.WriteLine("JSON data written to file successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing to file: {ex.Message}");
            }
        }

        // Read JSON data from a file
        public static T ReadFromJsonFile<T>(string filePath)
        {
            try
            {
                string jsonData = File.ReadAllText(filePath);
                T data = JsonSerializer.Deserialize<T>(jsonData);
                //Console.WriteLine("JSON data read from file successfully.");
                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading from file: {ex.Message}");
                return default(T);
            }
        }
    }
}
