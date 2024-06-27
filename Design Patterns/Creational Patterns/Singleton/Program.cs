using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational_Patterns.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Thread t1 = new Thread(() =>
            {
                var instance = DatabaseService.GetInstance("t1");
            });

            Thread t2 = new Thread(() =>
            {
                var instance = DatabaseService.GetInstance("t2");
            });

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();*/

            Thread[] threads = new Thread[10];

            for (int i = 0; i < threads.Length; i++)
            {
                int threadNumber = i + 1;
                threads[i] = new Thread(() =>
                {
                    var instance = DatabaseService.GetInstance($"t{threadNumber}");
                });
            }

            for (int i = 0; i < threads.Length; i++)
            {
                threads[i].Start();
            }
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i].Join();
            }


        }

    }
}
