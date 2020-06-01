using System;
using System.Collections;
namespace MyProgram
{
    class Program
    {
        public static void Main()
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            Queue intQ = new Queue();
            for (int i = 1; i <= n; i++)
                intQ.Enqueue(i);
            Console.WriteLine("Размерность очереди " + intQ.Count);
            Console.WriteLine("Верхний элемент очереди = " + intQ.Peek());
            Console.WriteLine("Размерность очереди " + intQ.Count);
            Console.Write("Содержание очереди = ");
            while (intQ.Count != 0)
                Console.Write("{0} ", intQ.Dequeue());
            Console.WriteLine("\nНовая размерность очереди " + intQ.Count);
        }
    }
}
