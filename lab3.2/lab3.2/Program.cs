using System;

namespace Arrays
{
    class Program
    {
        static void Main()
        {
            try
            {
                int[][] MyArray;
                Console.Write("Введите количество рядков: ");
                int n = int.Parse(Console.ReadLine());
                MyArray = new int[n][];
                for (int i = 0; i < MyArray.Length; i++)
                {
                    Console.Write("Введите количество элементов в {0} рядке: ", i);
                    int j = int.Parse(Console.ReadLine());
                    MyArray[i] = new int[j];
                    for (j = 0; j < MyArray[i].Length; j++)
                    {
                        Console.Write("a[{0}][{1}]= ", i, j);
                        MyArray[i][j] = int.Parse(Console.ReadLine());
                    }
                }
                PrintArray("выходящий массив:", MyArray);
                for (int i = 0; i < MyArray.Length; i++) Array.Sort(MyArray[i]);
                PrintArray("измененный массив", MyArray);
            }
            catch (FormatException)
            {
                Console.WriteLine("неверный формат ввода данных");
            }
            catch (OverflowException)
            {
                Console.WriteLine("переполнение");
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("недостаточно памяти для создания нового обьекта");
            }
        }
        static void PrintArray(string a, int[][] mas)
        {
            Console.WriteLine(a);
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = 0; j < mas[i].Length; j++) Console.Write("{0} ",
               mas[i][j]);
                Console.WriteLine();
            }
        }
    }

}

