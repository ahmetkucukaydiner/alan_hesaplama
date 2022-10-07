using alan_hesaplama.Operation;
using System;

namespace alan_hesaplama
{
    public class Program
    {
        static void Main(string[] args)
        {
            /* İşlem yapılmak istenen geometrik şekli kullanıcıdan alınmalı(Daire, Üçgen, Kare, Dikdörtgen vb..)
                Seçilen şekle göre, kenar bilgilerin kullanıcıdan alınmalı
                Hesaplanmak istenen boyutu kullanıcıdan alınmalı(Çevre, Alan, Hacim vb..)
                Hesap sonucunu anlaşılır şekilde geri döndürmeli.
                Dikkat Edilmesi Gereken Noktalar :

                Kod tekrarından kaçınılmalı
                Single Responsibility kuralına uygun şekilde, uygulama sınıflara ve metotlara bölünmeli. */

            Console.WriteLine("Geometrik şekillerin alan, hacim, çevre uzunluğu hesaplama programı");
            Console.WriteLine("Hesaplamasını yapmak istediğiniz şekli seçiniz : \n (1) Daire \n (2) Üçgen \n (3) Dikdörtgen \n (4) Kare");
            char choice = Convert.ToChar(Console.ReadLine());

            Circle circle = new Circle();
            Rectangle rectangle = new Rectangle();
            Square square = new Square();
            Triangle triangle = new Triangle();

            switch (choice)
            {
                case '1':
                    WriteLog();
                    char choice2 = Convert.ToChar(Console.ReadLine());

                    switch (choice2)
                    {
                        case '1':
                            circle.CalculateArea();
                            break;
                        case '2':
                            circle.CalculatePerimeter();
                            break;
                        case '3':
                            circle.CalculateBulk();
                            break;
                        default:
                            FailException();
                            break;
                    }
                    break;

                case '2':
                    WriteLog();
                    char choice3 = Convert.ToChar(Console.ReadLine());
                    switch (choice3)
                    {
                        case '1':
                            triangle.CalculateArea();
                            break;
                        case '2':
                            triangle.CalculatePerimeter();
                            break;
                        case '3':
                            triangle.CalculateBulk();
                            break;
                        default:
                            FailException();
                            break;
                    }
                    break;
             
                case '3':
                    WriteLog();
                    char choice4 = Convert.ToChar(Console.ReadLine());

                    switch (choice4)
                    {
                        case '1':
                            rectangle.CalculateArea();
                            break;
                        case '2':
                            rectangle.CalculatePerimeter();
                            break;
                        case '3':
                            rectangle.CalculateBulk();
                            break;
                        default:
                            FailException();
                            break;
                    }
                    break;
                    
                case '4':
                    // WriteLog();
                    Console.WriteLine("Yapmak istediğiniz işlemi seçin:\n (1) Alan \n (2) Çevre \n (3) Hacim");
                    char choice5 = Convert.ToChar(Console.ReadLine());

                    switch (choice5)
                    {
                        case '1':
                            square.CalculateArea();
                            break;
                        case '2':
                            square.CalculatePerimeter();
                            break;
                        case '3':
                            square.CalculateBulk();
                            break;
                        default:
                            FailException();
                            break;
                    }
                    break;
            }
        }
        static void WriteLog()
        {
            Console.WriteLine("Yapmak istediğiniz işlemi seçin:\n (1) Alan \n (2) Çevre \n (3) Hacim");
        }

        static void FailException()
        {
            Console.WriteLine("Seçeneklerden farklı bir değer girdiniz!");
        }
    }
}

