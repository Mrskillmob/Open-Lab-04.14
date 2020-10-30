using System;

namespace Open_Lab_04._14
{
    public class FramePrinter
    {
        public void Print(string[] strings)
        {
            int b = 0;
            string h = "*";
            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i].Length > b)
                {
                    b = strings[i].Length;
                }
            }
            for (int i = 1; i < b + 4; i++)
            {
                Console.Write(h);
            }
            Console.WriteLine(h);
            for (int i = 0; i < strings.Length; i++)
            {
                Console.Write(h + " ");
                Console.Write(strings[i]);
                for (int s = 0; s < b - strings[i].Length; s++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(" " + h);
            }
            for (int i = 1; i < b + 4; i++)
            {
                Console.Write(h);
            }
            Console.WriteLine(h);
        }
    }
}