using System;

namespace Масивы
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            int velue1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int velue2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите номер операции: \n1.Сложение \n2.Вычитание \n3.Умножение");
            int result = int.Parse(Console.ReadLine());
            

            switch (result)
            {
                case 1:
                    int r1 = velue1 + velue2;
                    Console.WriteLine("Сложение\t" +  r1);
                    break;
                case 2:
                    int r2 = velue1 - velue2;
                    Console.WriteLine("Вычитание\t" +  r2);
                    break;
                case 3:
                    int r3 = velue1 * velue2;
                    Console.WriteLine("Умножение\t" +  r3);
                    break;
                default:
                    Console.WriteLine("Операция неопределена");
                    break;
            }

            Console.ReadLine();
        }
    }
}
