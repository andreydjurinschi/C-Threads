using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Threads
{
    internal class SortWordsThread
    {
        private string _text = string.Empty;

        public SortWordsThread(string text) 
        {
            this._text = text;
        }

        public void PrintArray(string[] words)
        {
            Console.WriteLine("Отсортированные слова по длине: ");
            foreach (string word in words)
            {
                Console.Write(word + " ");
            }
        }



        public void SortWords()
        {
            Console.WriteLine("Разбиваем ваш текст на слова...");
            string[] words = _text.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            Thread.Sleep(1000);

            for (int i = 0; i < words.Length - 1; i++) 
            {
                for (int j = 0; j < words.Length - 1 - i; j++) 
                {
                    if (words[j].Length > words[j + 1].Length) 
                    {
                        string temp = words[j];
                        words[j] = words[j + 1];
                        words[j + 1] = temp;
                    }
                }
            }

            PrintArray(words);
            Thread.Sleep(1000);
        }
    }
}
