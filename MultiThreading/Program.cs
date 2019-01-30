using System;
using System.Threading.Tasks;

namespace MultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void ThreadingThruTask()
        {
            var t1 = new Task(() =>
            {
                Console.WriteLine("task 1");
            });
            t1.Start();
        }
    }

}
