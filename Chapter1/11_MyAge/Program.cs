using System;

namespace _11_MyAge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age:");
            int age =  int.Parse(Console.ReadLine());
            Console.WriteLine("Your age after 10 years will be {0}", age + 10);
        }
    }
}
