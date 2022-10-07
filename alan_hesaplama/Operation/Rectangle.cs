using alan_hesaplama.Actions;
using System;
using System.Collections.Generic;
using System.Text;

namespace alan_hesaplama.Operation
{
    public class Rectangle : ICalculate
    {
        public void CalculateArea()
        {
            Console.WriteLine("Kısa kenarı giriniz: ");
            int shortEdge = int.Parse(Console.ReadLine());

            Console.WriteLine("Uzun kenarı giriniz: ");
            int longEdge = int.Parse(Console.ReadLine());

            //return shortEdge * longEdge;
            Console.WriteLine(shortEdge * longEdge);
        }

        public void CalculateBulk()
        {
            throw new NotImplementedException();
        }

        public void CalculatePerimeter()
        {
            Console.WriteLine("Kısa kenarı giriniz: ");
            int shortEdge = int.Parse(Console.ReadLine());

            Console.WriteLine("Uzun kenarı giriniz: ");
            int longEdge = int.Parse(Console.ReadLine());

            //return (shortEdge + longEdge) * 2;
            Console.WriteLine((shortEdge + longEdge) * 2);
        }
    }
}
