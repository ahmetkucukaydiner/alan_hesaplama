using alan_hesaplama.Actions;
using System;
using System.Collections.Generic;
using System.Text;

namespace alan_hesaplama.Operation
{
    public class Circle : ICalculate
    {
        public void CalculateArea()
        {
            Console.WriteLine("Yarı çap uzunluğunu giriniz: ");
            int radius = int.Parse(Console.ReadLine());

            int area = (int)Math.PI * (int)Math.Pow(radius, 2);

            //return area;
            Console.WriteLine(area);
        }

        public void CalculateBulk()
        {
            throw new NotImplementedException();
        }

        public void CalculatePerimeter()
        {
            Console.WriteLine("Yarı çap uzunluğunu giriniz: ");
            int radius = int.Parse(Console.ReadLine());

            int perimeter = (int)Math.PI * 2 * radius;

            //return perimeter;
            Console.WriteLine(perimeter);
        }
    }
}
