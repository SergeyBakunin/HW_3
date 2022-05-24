using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3
{
    class Exercise_1
    {
        public void Diagonal()
        {
            int next_string = 0;
            int[,] array = new int[5, 5];
            Random ran = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = ran.Next(1, 9);
                    Console.WriteLine($"{new string(' ', next_string)}{array[i, j]}");
                    next_string++;
                }
            }
        }
    }
    class Exercise_2
    {
        public void PhoneDirectory()
        {
            string[,] guide = new string[5, 2];
            guide[0, 0] = "Ростов";
            guide[0, 1] = "8(812)371-23-56";
            guide[1, 0] = "Никола";
            guide[1, 1] = "8(953)189-32-81";
            guide[2, 0] = "Сергей";
            guide[2, 1] = "8(981)156-09-11";
            guide[3, 0] = "Никита";
            guide[3, 1] = "8(911)166-76-93";
            guide[4, 0] = "Андрей";
            guide[4, 1] = "8(921)917-12-95";

            for (int i = 0; i < guide.GetLength(0); i++)
            {
                for (int j = 0; j < guide.GetLength(1); j++)
                {
                   Console.Write($"{guide[i, j]} ");
                }
                Console.WriteLine();
            }

        }
    }
    class Exercise_3
    {
        public void Reverse()
        {
            Console.WriteLine("Введите вашу строку: ");
            string line = Console.ReadLine();
            char[] reverse = line.Reverse().ToArray();
            Console.WriteLine(reverse);
        }
    }
    internal class HW_3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберете задание: ");
            Console.WriteLine("1 - вывести матрицу строчкой по диагонали");
            Console.WriteLine("2 - телефонный справочник");
            Console.WriteLine("3 - реверсирование строки");
            int value = int.Parse(Console.ReadLine());

            switch (value)
            {
                case 1:
                    Exercise_1 diagonal = new Exercise_1();
                    diagonal.Diagonal();
                    break;

                case 2:
                    Exercise_2 guide = new Exercise_2();
                    guide.PhoneDirectory();
                    break;

               case 3:
                    Exercise_3 reverse = new Exercise_3();
                    reverse.Reverse();
                    break;
               
                default:
                    Console.WriteLine("Ошибка! Укажите значение от 1 до 3");
                    break;
            }
            Console.ReadKey();
        }
    }
}
