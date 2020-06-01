using System;
using System.IO;

namespace ComsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            byte dcounter = 0, 
            wcounter = 0;  
            string stroka;
            int i;
            using (StreamReader MyFile = new StreamReader("путь к файлу/test.txt"))
            {
                
                while ((stroka = MyFile.ReadLine()) != null)
                {
                    Console.WriteLine(stroka);
                    i = 0; 
                    while (i < stroka.Length)
                    {
                       
                        while ((i < stroka.Length) && !(char.IsLetterOrDigit(stroka, i)))
                        {
                            i++;
                        }
                       
                        if ((i < stroka.Length) && (char.IsDigit(stroka, i)))
                            dcounter++;
                       
                        while ((i < stroka.Length) && (char.IsDigit(stroka, i)))
                        {
                            i++;
                        }
                        
                        if ((i < stroka.Length) && (char.IsLetter(stroka, i)))
                            wcounter++;
                        
                        while ((i < stroka.Length) && (char.IsLetter(stroka, i)))
                        {
                            i++;
                        }
                    }
                }
            }
            if (wcounter > dcounter)
            {
                Console.Write("Групп букв больше: ");
                Console.WriteLine("{0}>{1}", wcounter, dcounter);
            }
            else if (dcounter > wcounter)
            {
                Console.Write(" Групп цифр больше: ");
                Console.WriteLine(" {0}>{1}.", dcounter, wcounter);
            }
            else
            {
                Console.Write(" Групп цифр и букв равное количество: ");
                Console.WriteLine(" {0} = {1}.", wcounter, dcounter);
            }
            Console.ReadLine();
        }
    }
}
