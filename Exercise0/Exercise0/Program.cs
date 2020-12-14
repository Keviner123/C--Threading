using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercise0
{

    class Program
    {
        public void WorkThreadFunction()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Simple Thread");
                Thread thread1 = new Thread(new ThreadStart(Thread1));
                thread1.Name = "Thread1";
                thread1.Start();
                thread1.Join();
                Console.WriteLine(thread1.Name);

                Thread thread2 = new Thread(new ThreadStart(Thread2));
                thread2.Name = "Thread2";
                thread2.Start();
                thread2.Join();
                Console.WriteLine(thread2.Name);
            }
        }

        public void Thread1()
        {
            Console.WriteLine("Thread1");
        }

        public void Thread2()
        {
            Console.WriteLine("Thread2");
        }
    }

    class threprog
    {
            public static void Main()
            {
                Program pg = new Program();
                Thread thread = new Thread(new ThreadStart(pg.WorkThreadFunction));
                thread.Start();
                Console.Read();
            }
    }
}
