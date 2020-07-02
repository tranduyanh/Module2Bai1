using System;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
                float width;
                float heigth;
                Console.Write("Enter width: ");
                width = float.Parse(Console.ReadLine());
                Console.Write("Enter heigth: ");
                heigth = float.Parse(Console.ReadLine());
                float area = width * heigth;
                Console.WriteLine("Area is: " + area);
        }
    }
}
