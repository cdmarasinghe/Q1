using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q1
{
    class Program
    {
        public void multiples()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                        Console.WriteLine("SupportTraining");
                    else
                    {
                        if (i % 3 == 0)
                            Console.WriteLine("Support");
                        if (i % 5 == 0)
                            Console.WriteLine("Training");
                    }
                }
                else
                    Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.multiples();
        }
    }
}
