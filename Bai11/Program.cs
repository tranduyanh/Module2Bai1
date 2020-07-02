using System;

namespace Bai11
{
    class Program
    {
        static void Main(string[] args)
        {
            double heigth;
            double weigth;
            Console.WriteLine("cai chieu cao: ");
            heigth = float.Parse(Console.ReadLine());
            Console.WriteLine("nhap can nang; ");
            weigth = float.Parse(Console.ReadLine());
            double bmi = weigth / Math.Pow(heigth,2);
            bmi = Math.Round(bmi, 1);
            Console.Write("BMI: " + bmi);
            if (bmi < 18) 
            {
                Console.WriteLine(" underweigth");
            }
            else if (bmi < 25.0)
            {
                Console.WriteLine(" Normal");
            }
            else if (bmi < 30.0)
            {
                Console.WriteLine(" over weigth ");
            }
            else 
            {
                Console.WriteLine(" Obese ");
            }
        }
    }
}
