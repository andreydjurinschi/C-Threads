using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace C_Threads
{
    internal class Program
    {
        public static void Main(string[] args) 
        {
            string filePath = @"C:\Users\Calculator\source\repos\C#Threads\C#Threads\Files\TextFile1.txt";

            string text = FileReader.ReadTextFromFile(filePath);
            if (string.IsNullOrEmpty(text)) 
            {
                Console.WriteLine("Ваш текстоввый вайл пуст");
                return;
            }

            MaxWordThread maxWordThread = new MaxWordThread(text);
            SortWordsThread sortWordsThread = new SortWordsThread(text);

            Console.WriteLine("Ждем запуска первого процесса на поиск максимального слова в тексте...");
            Thread thread1 = new Thread(maxWordThread.findMaxWord);
            thread1.Start();
            Thread.Sleep(1000);
            thread1.Join();
            Console.WriteLine("Процесс успешно завершен, ждем запуск второго процесса");
            Thread thread2 = new Thread(sortWordsThread.SortWords);
            Thread.Sleep(1000);
            thread2.Start();
            thread2.Join();

        }
    }
}
