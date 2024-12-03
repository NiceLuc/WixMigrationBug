using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var obj = new ClassLibrary1.Class1 {Name = "World" };
            Console.WriteLine($"Hello {obj.Name}");
            Console.ReadKey();
        }
    }
}
