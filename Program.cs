/*Пользователь вводит с клавиатуры два числа. Нужно
показать все четные числа в указанном диапазоне. Если
границы диапазона указаны неправильно требуется про-
извести нормализацию границ. Например, пользователь
ввел 20 и 11, требуется нормализация, после которой
начало диапазона станет равно 11, а конец 20.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Доброго дня \n Введіть будь-ласка початок діапазону");
            string first = Console.ReadLine();
            int firstNumber = Convert.ToInt32(first);
            Console.WriteLine("Введіть будь-ласка кінець діапазону");
            string second = Console.ReadLine();
            int secondNumber = Convert.ToInt32(second);
            if (firstNumber>secondNumber)
            {
                (firstNumber, secondNumber) = (secondNumber, firstNumber);
                Console.WriteLine("Ви ввели неправельно межі діапазону,\n початок діапазону повинен бути меншим за кінець! \nТому розвертаємо значення:");
                Console.WriteLine($"Перше число: {firstNumber}");
                Console.WriteLine($"Друге число: {secondNumber}");
            }
            for (int i = firstNumber; i < secondNumber; i++)
            {
                if (i % 2 == 0) 
                {
                    Console.WriteLine($"Число {i} парне з данного даапазону)") ;
                }
            }


            Console.WriteLine("Дякуємо!!!");
            Console.ReadKey();
        }

    }
}
