using System;

namespace Arrays
{
    class Program
    {
        static void PrintArray(string a, int[,] mas)
        {
            Console.WriteLine(a);
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                    Console.Write("{0} ", mas[i, j]);
                Console.WriteLine();
            }
        }
        static void Change(int[,] mas)
        {
            for (int i = 0; i < mas.GetLength(0); i++)
                for (int j = 0; j < mas.GetLength(1); j++)
                    if (mas[i, j] % 2 == 0) mas[i, j] = 0;
        }
        static void Main()
        {
            try
            {
                int[,] MyArray = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
                PrintArray("входящий массив:", MyArray);
                Change(MyArray);
                PrintArray("итоговый массив", MyArray);
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
                Console.WriteLine("недостаточно помяти для создания нового обьекта");
            }
        }
    }
}
