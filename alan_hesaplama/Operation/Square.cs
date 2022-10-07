using alan_hesaplama.Actions;
using System;
using System.Collections.Generic;
using System.Text;

namespace alan_hesaplama.Operation
{
    internal class Square : ICalculate
    {
        public void CalculateArea()
        {
            Console.WriteLine("Kenar uzunluğu giriniz: ");
            int edge = int.Parse(Console.ReadLine());

            int area = (int)Math.Pow(edge, 2);

            //return area;
            Console.WriteLine(area);
        }

        public void CalculateBulk()
        {
            throw new NotImplementedException();
        }

        public void CalculatePerimeter()
        {
            Console.WriteLine("Kenar Uzunluğu giriniz: ");
            int edge = int.Parse(Console.ReadLine());

            int perimeter = edge * 4;

            //return perimeter;
            Console.WriteLine(perimeter);
        }
    }
}
