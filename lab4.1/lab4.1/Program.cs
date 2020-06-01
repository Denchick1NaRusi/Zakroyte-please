using System;
using System.IO;
using System.Text;

namespace ComsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0; 
            string line;                
            char[] separator = { ' ', '.', '*', '+', ';', ',', '?', '!', '‐', '/' }; 
            StringBuilder otvet = new StringBuilder();  
            using (StreamReader MyFile = new StreamReader("text.txt"))
            {
                
                while ((line = MyFile.ReadLine()) != null)
                {
                    Console.WriteLine(line);  
                                             
                    string[] words = line.Split(separator);
                    foreach (string slovo in words) 
                    {
                        if ((slovo.Length >= 2) && (slovo[1] == 'd'))
                        {
                            counter++;
                            otvet.Append(slovo);
                            otvet.Append("  ");
                        }
                    }
                }
            }
            Console.WriteLine("There were {0} sequences.", counter);
            Console.WriteLine(otvet.ToString());
            Console.ReadLine();
        }
    }
}


