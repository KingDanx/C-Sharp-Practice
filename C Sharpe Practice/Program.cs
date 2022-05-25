using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharpe_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Book cat = new Book(4, "Cats R Us", "Madam Heart");
            Console.WriteLine(cat.title + " by " + cat.author + " pages: " + cat.pages);
            Console.ReadLine();
        }
    }
}
