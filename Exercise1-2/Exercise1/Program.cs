using Exercise1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercise1
{
    class program
    {
        public void WorkThreadFunction()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("C#-trådning er nemt!");
            }
        }

        public void WorkThreadFunction1()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Også med flere tråde …!");
            }
        }
    }
}

class threprog
{
    public static void Main()
    {
        program pg = new program();
        Thread thread1 = new Thread(pg.WorkThreadFunction);
        Thread thread2 = new Thread(pg.WorkThreadFunction1);

        thread1.Start();
        thread2.Start();

        Console.Read();
    }
}