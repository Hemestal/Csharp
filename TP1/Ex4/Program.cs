using System;
using System.Threading;

namespace Ex4
{
    class T
    {
        public void A()
        {
            while (true)
            {
                Console.WriteLine("A");
                System.Threading.Thread.Sleep(1000);
            }
        }
        public void B()
        {
            while (true)
            {
                Console.WriteLine("B");
                System.Threading.Thread.Sleep(1000);
            }
        }
        public void C()
        {
            while (true)
            {
                Console.WriteLine("C");
                System.Threading.Thread.Sleep(1000);
            }
        }
        public void D()
        {
            while (true)
            {
                Console.WriteLine("D");
                System.Threading.Thread.Sleep(1000);
            }
        }
        public void E()
        {
            while (true)
            {
                Console.WriteLine("E");
                System.Threading.Thread.Sleep(1000);
            }
        }
        static void Main(string[] args)
        {
            T obj1 = new T();
            Thread A = new Thread(obj1.A);
            A.Start();
            Thread B = new Thread(obj1.B);
            B.Start();
            Thread C = new Thread(obj1.C);
            C.Start();
            Thread D = new Thread(obj1.D);
            D.Start();
            Thread E = new Thread(obj1.E);
            E.Start();

        }
    }
}
