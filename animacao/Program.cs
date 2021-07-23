using System;

namespace animacao
{
    class Program
    {
        static void Main(string[] args)
        {

            //for (int a = 0; a < 10; a++)
            //{
            //    for (int i = 1; i < 10; i++)
            //    {
            //        for (int j = 1; j < i; j++)
            //            Console.Write("x");
            //        Console.Write("\n");
            //    }
            //    for (int i = 1; i < 10; i++)
            //    {
            //        for (int j = 10; j > i; j--)
            //            Console.Write("x");
            //        Console.Write("\n");
            //    }
            //    System.Threading.Thread.Sleep(50);
            //    Console.Clear();
            //    for (int i = 1; i < 10; i++)
            //    {
            //        for (int j = 10; j > i; j--)
            //            Console.Write(" ");
            //        for (int j = 1; j < i; j++)
            //            Console.Write("x");
            //        Console.Write("\n");

            //    }
            //    for (int i = 1; i < 10; i++)
            //    {
            //        for (int j = 1; j < i; j++)
            //            Console.Write(" ");
            //        for (int j = 10; j > i; j--)
            //            Console.Write("x");

            //        Console.Write("\n");
            //    }
            //    System.Threading.Thread.Sleep(50);
            //}
            for (int a = 0; a < 10; a++)
            {
                System.Threading.Thread.Sleep(200);
                Console.Clear();
                for (int i = 1; i < 10; i++)
                {
                    for (int j = 1; j < i; j++)
                        Console.Write("x");
                    Console.Write("\n");
                }
                for (int i = 1; i < 10; i++)
                {
                    for (int j = 10; j > i; j--)
                        Console.Write("x");
                    Console.Write("\n");
                }
                System.Threading.Thread.Sleep(200);
                Console.Clear();
                for (int i = 1; i < 10; i++)
                {
                    for (int j = 1; j < i; j++)
                        Console.Write("x");
                    Console.Write("\n");
                    for (int j = 10; j > i; j--)
                        Console.Write("x");
                    Console.Write("\n");
                }
                System.Threading.Thread.Sleep(200);
                Console.Clear();
                for (int i = 1; i < 10; i++)
                {
                    for (int j = 10; j > i; j--)
                        Console.Write("x");
                    Console.Write("\n");
                }
                for (int i = 1; i < 10; i++)
                {
                    for (int j = 1; j < i; j++)
                        Console.Write("x");
                    Console.Write("\n");
                }
            }
        }
    }
}
