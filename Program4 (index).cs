using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp77
{
    public class Word
    {
        /// <summary>
        /// Исходное слово
        /// </summary>
        public string Source { get; }

        /// <summary>
        /// Перевод исходного слова
        /// </summary>
        public string Target { get; set; }

        public Word(string source, string target)
        {
            Source = source;
            Target = target;
        }
    }

    public class Dictionary
    {
        Word[] words;
        public Dictionary()
        {
            words = new Word[]
            {
            new Word("red", "красный"),
            new Word("blue", "синий"),
            new Word("green", "зеленый")
            };
        }

        public string this[string index]
        {
            get
            {
                foreach (var word in words)
                    if (word.Source == index)
                        return word.Target;
                return null;
            }
            set
            {
                foreach (var word in words)
                    if (word.Source == index)
                    {
                        word.Target = value;
                        break;
                    }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary dict = new Dictionary();
            Console.WriteLine(dict["blue"]); // синий
            dict["blue"] = "голубой";
            Console.WriteLine(dict["blue"]); // голубой
        }
    }
}
