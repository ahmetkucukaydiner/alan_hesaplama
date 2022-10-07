using alan_hesaplama.Actions;
using System;
using System.Collections.Generic;
using System.Text;

namespace alan_hesaplama.Operation
{
    public class Triangle : ICalculate
    {
        public void CalculateArea()
        {
            Console.WriteLine("Taban uzunluğunu giriniz: ");
            int floor = int.Parse(Console.ReadLine());

            Console.WriteLine("Yükseklik giriniz: ");
            int height = int.Parse(Console.ReadLine());

            //return (floor * height) / 2;
            Console.Write((floor * height) / 2);
        }

        public void CalculateBulk()
        {
            throw new NotImplementedException();
        }

        public void CalculatePerimeter()
        {
            Console.WriteLine("Birinci kenar uzunluğunu giriniz: ");
            int firstEdge = int.Parse(Console.ReadLine());

            Console.WriteLine("İkinci kenar uzunluğunu giriniz: ");
            int secondEdge = int.Parse(Console.ReadLine());

            Console.WriteLine("Taban uzunluğunu giriniz: ");
            int floor = int.Parse(Console.ReadLine());

            //return firstEdge + secondEdge + floor;
            Console.WriteLine(firstEdge + secondEdge + floor);
        }
    }
}
