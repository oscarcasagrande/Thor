using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Thor
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(NovaThread);
            Thread t2 = new Thread(() => MaisUmaNovaThread(100));
            t.Start();
            t2.Start();
            

            for (int i = 0; i < 100; i++) Console.Write("1");

            Console.Read();
        }

        static void NovaThread()
        {
            for (int i = 0; i < 100; i++) Console.Write("2");
        }

        static void MaisUmaNovaThread(int x)
        {
            for (int i = 0; i < x; i++) Console.Write("3");
        }
    }
}
