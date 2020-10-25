using System;

namespace TP2
{
    public delegate void Primedel(object o, PrimeEventArgs pe);
    public class PrimeEventArgs : System.EventArgs
    {
        private long _prime;
        public long Prime
        {
            get { return _prime; }
        }
        public PrimeEventArgs(long p) : base()
        {
            _prime = p;
        }
        static void Main(string[] args)
        {
            PrimeSender ps = new PrimeSender();
            PrimeReceiver pr = new PrimeReceiver();
            ps.MyDel += pr.action;
            ps.calculatePrime(1000);
            System.Console.ReadLine();
        }
    }
    public class PrimeSender : System.EventArgs
    {
        public event Primedel MyDel;
        public void calculatePrime(long max)
        {
            for (int i = 2; i < max; i++)
            {
                if (isprime(i))
                {
                    raiseEvents(i);
                }
            }
        }
        public bool isprime(double n)
        {
            if (n <= 1)
            {
                return false;
            }
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public void raiseEvents(long p)
        {
            onMyDel(this, new PrimeEventArgs(p));
        }
        protected virtual void onMyDel(object o, PrimeEventArgs pe)
        {
            if (MyDel != null) MyDel(o, pe);
        }
    }
    public class PrimeReceiver : System.EventArgs
    {
        public void action(object o, PrimeEventArgs pe)
        {
            System.Console.WriteLine("Prime number found:" + pe.Prime);
        }
        public void action1(object o, PrimeEventArgs pe)
        {
            System.Console.WriteLine("actioned1");
        }
        public void action2(object sender, PrimeEventArgs pe)
        {
            System.Console.WriteLine("actioned2");
        }
    }

}
