using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            string poem = "Вот дом , Который построил Джек .А это пшеница ,Которая в темном чулане хранится В доме , Который построил Джек" + "  Вот пес без хвоста, Который за шиворот треплет кота...";
            string[] words = poem.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<int, string> openWith = new Dictionary<int, string>();
            int num = 0, count = 0;
            Console.WriteLine("\t\tСлово  \t\tКоличество \n");
            for (int i = 0; i < words.Length; i++)
            {
                count++;
                openWith.Add(count, words[i]);
            }

            foreach (KeyValuePair<int, string> keyValue in openWith)
            { for (int i = 0; i < words.Length; i++)
                { if (words[i] == keyValue.Value)
                    { num++; }
                    else {  }
                }


                Console.WriteLine("  " + keyValue.Key + ".\t\t" + keyValue.Value + "\t\t" + num);

            } 
          
                Console.ReadLine();
        }
    }
}
