using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace E_Commerce_Cart_API_UI.Utils
{
    public class FileUtils
    {

        public void Save<T>(string path, JsonSerializerOptions jsonOptions, T data)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(data, jsonOptions);
                File.WriteAllText(path, jsonString);
                Console.WriteLine($"[Successfull] - Data was written to {path}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Fail] - Data cannot be written. Occurred an error: {ex}");
            }
        }

        public T? Read<T>(string path, JsonSerializerOptions jsonOptions)
        {
            try
            {
                if (!File.Exists(path))
                {
                    Console.WriteLine($"[Fail] - {path} cannot be found.");
                    return default;
                }

                string jsonString = File.ReadAllText(path);
                Console.WriteLine($"[Successfull] - {path} was read.");
                return JsonSerializer.Deserialize<T>(jsonString, jsonOptions);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Fail] - Occurred an error: {ex}");
                return default;
            }
        }

        public void Clean(string path)
        {
            File.Delete(path);
            Console.WriteLine($"[Successfull] - {path} was deleted.");
        }
    }
}
