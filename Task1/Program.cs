using System;
namespace Homework
{
    class Program
    {

        static void Main(string[] args)
        {
            void Zadacha1()
            {
                int number = new Random().Next(100, 1000);
                int a = number / 10 % 10;
                Console.WriteLine(number);
                Console.WriteLine(a);
            }

            void Zadacha2()
            {
                int Number = new Random().Next();
                // Console.WriteLine("Введите число");
                // int Number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Number);
                if (Number < 100)
                {
                    Console.WriteLine("нет третьего числа");
                }
                while (Number > 1000)
                {
                    Number = Number / 10;
                }
                Number = Number % 10;
                Console.WriteLine(Number + " является третьим числом");
            }

            void Zadacha3()
            {
                Console.WriteLine("Введите число, обозначающее день недели:");
                int read = Convert.ToInt32(Console.ReadLine());
                int Saturday = 6;
                int Sunday = 7;
                if (read == Saturday | read == Sunday)
                {
                    Console.WriteLine("Это выходной день");
                }
                else if (read < 1 | read > 7)
                {
                    Console.WriteLine("Не является днём недели");
                }
                else
                {
                    Console.WriteLine("Это НЕ выходной день");
                }
            } 

            //Zadacha1();
            //Zadacha2();
            //Zadacha3();

            
        }
    }
}