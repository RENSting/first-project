using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 100; i++)
            {
                string n = i.ToString();
                if(n.Contains("7"))
                {
                    Console.WriteLine("github");
                    continue;
                }
                
                int m3 = i % 3;
                int m5 = i % 5;
                if(m3 == 0 && m5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else
                {
                    if(m3 == 0)
                    {
                        Console.WriteLine("fizz");
                    }
                    else if(m5==0)
                    {
                        Console.WriteLine("buzz");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
