using System;
using System.Collections;
using System.Diagnostics.Tracing;
using System.Dynamic;

namespace TP1
{
    class X
    {
        public static int counter=0;
        public override string ToString()// permet de changer à l'affichage
        {
            counter++;
            return "Object from Class X (number "+counter+")";
        }

    }
    class P
    {
        private long x;
        private long _min;
        private long _max;
        public P()
        {
            _min = 0;
            _max = 100;
        }
        
        public long getx()
        {
            return x;
        }
        public long get_min()
        {
            return _min;
        }
        public long get_max()
        {
            return _max;
        }
        public void set_x(long y)// doit changer en valeur strictement positive
        {
            if(y<0)
            {
                x = y * (-1);
            }
            else if(y==0)
            {
                x = 1;
            }
            else
            {
                x = y;
            }
            
        }
        public void set_min(long x)
        {
            if(_max<x)
            {
                _max = x + 1;
            }
                _min = x;
            
        }
        public void set_max(long x)
        {
            if (_min > x)
            {
                _min = x - 2;
            }
            _max = x;
        }
    }

    abstract class instrument
    {
        public abstract void play();
    }
    class Brass : instrument
    {
        public Brass()
        {
            Console.WriteLine("brass constructor");
        }
        public override void play()
        {
            Console.WriteLine("je joue un son avec un instrument a cuivre");
            Blow();
        }
        public virtual void Blow()
        {
            Console.WriteLine("je souffle un son avec un instrument a cuivre");
        }
    }
    class Trumpet : Brass
    {
        public Trumpet()
        {
            Console.WriteLine("Trumpet constructor");
        }
        public override void play()
        {
            Console.WriteLine("je joue un son avec une trompette");
            Blow();
        }
        public override void Blow()
        {
            Console.WriteLine("je souffle un son avec une trompette");
        }
    }
    class test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********Ex1*************");
            X obj1, obj2;
            obj1 = new X();
            obj2 = new X();
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);

            Console.WriteLine("*************Ex2*************");
            P objP = new P();
            objP.set_x(-14);
            Console.WriteLine("a/");
            Console.WriteLine(objP.getx());
            objP.set_max(3);
            objP.set_min(15);
            Console.WriteLine("b/");
            Console.WriteLine(objP.get_max());
            Console.WriteLine(objP.get_min());

            Console.WriteLine("************Ex3*************");
            new Trumpet().play();
        }
    }
}