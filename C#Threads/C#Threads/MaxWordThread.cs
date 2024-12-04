using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Threads
{
    public class MaxWordThread
    {
        private string _text;
        private string _maxWord = string.Empty;

        public MaxWordThread(string text) 
        {
            this._text = text;
        }

        public void findMaxWord() 
        {
            Console.WriteLine("Разбиваем ваш текст на слова...");
            string[] words = _text.Split(new char[] {' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            Thread.Sleep(1000);
            _maxWord = " ";
            Console.WriteLine("Готово, ищем самое длинное слово в вашем тексте...");
            foreach (string word in words) 
            {
                if (word.Length > _maxWord.Length) 
                {
                _maxWord = word;
                }
            }
            Thread.Sleep(1000);
            Console.WriteLine($"Самое длинное слово в тексте: {_maxWord}, кол-во символов: {_maxWord.Length}");

        }


    }
}
