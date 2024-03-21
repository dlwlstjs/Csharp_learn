using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld //패키지
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string aFriend = "Bill";
            Console.WriteLine(aFriend);

            aFriend = "Maira";
            Console.WriteLine(aFriend);

            Console.WriteLine("Hello " + aFriend);

            Console.WriteLine($"Hello {aFriend}");
        }
    }
}