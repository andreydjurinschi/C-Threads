using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Threads
{
    internal class FileReader
    {
            public static string ReadTextFromFile(string filePath)
            {
                try
                {
                    string text = File.ReadAllText(filePath);
                    return text;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
                    return string.Empty;
                }
            }
        }
    }
