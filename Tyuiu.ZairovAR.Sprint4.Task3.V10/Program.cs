using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ZairovAR.Sprint4.Task3.V10.Lib;
namespace Tyuiu.ZairovAR.Sprint4.Task3.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[,] array = new int[5, 5] { { 5, 7, 6, 6, 5 },
                                           { 5, 5, 5, 4, 6 },
                                           { 8, 5, 7, 4, 7 },
                                           { 7, 6, 7, 4, 7 },
                                           { 5, 8, 7, 8, 8 } };
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            Console.Title = "Спринт #4 | Выполнил: Заиров А.Р. | АСОиУб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                              *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Заиров Артур Ранисович | АСОиУб-23-2                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 4 до 8.                          *");
            Console.WriteLine("* Найдите максимальный элемент в третьей строке массива.                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine(array[i, j]);
                }
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Максимальный элемент в третьей строке массива : {ds.Calculate(array)}");
            Console.ReadKey();
        }
    }
}
