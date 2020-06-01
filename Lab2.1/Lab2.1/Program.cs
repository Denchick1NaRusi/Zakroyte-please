using System;
namespace SeeMark
{
    public class Program
    {
        public static void Main()
        {
            double W, mStart, mFinish, mPas, vStart, vFinish, vPas = 1;
            Console.Write("Введите начальную массу - ");
            mStart = double.Parse(Console.ReadLine());
            Console.Write("Введите конечную массу - ");
            mFinish = double.Parse(Console.ReadLine());
            Console.Write("Введите шаг изменения массы - ");
            mPas = double.Parse(Console.ReadLine());
            Console.Write("Введите начальную скорость - ");
            vStart = double.Parse(Console.ReadLine());
            Console.Write("Введите конечную скорость - ");
            vFinish = double.Parse(Console.ReadLine());
            Console.Write("Введите шаг изменения скорости - ");
            vPas = double.Parse(Console.ReadLine());

            while (mStart < mFinish)
            {
                for (double i = vStart; i < vFinish; i += vPas)
                {
                    W = mStart * (Math.Pow(i, 2) / 2);
                    Console.WriteLine("W = {0} при m = {1} и v={2}", W, mStart, i);
                }
                mStart += mPas;
            }
            Console.ReadKey();


        }
    }
}