using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input 3 words!");

            Console.Write("Input First Word: ");
            var word1 = Console.ReadLine();

            Console.Write("Input Second Word: ");
            var word2 = Console.ReadLine();

            Console.Write("Input Third Word: ");
            var word3 = Console.ReadLine();

            Console.Write("Which Word Do You Like? ");
            var word = int.Parse(Console.ReadLine());

            if (word == 1)
            {
                Console.WriteLine("Your Word Is " + word1);
            }
            if (word == 2)
            {
                Console.WriteLine("Your Word Is " + word2);
            }
            if (word == 3)
            {
                Console.WriteLine("Your Word Is " + word3);
            }
        }
    }
}
