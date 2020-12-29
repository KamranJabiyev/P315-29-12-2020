using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Program
    {
        static void GetEagleSeeMethod(object[] arr)
        {
            foreach (var item in arr)
            {
                Eagle eagle = item as Eagle;
                if (eagle != null) eagle.See();
            }
        }
        static void Main(string[] args)
        {
            #region Upcasting,boxing,implicit
            //Eagle eagle = new Eagle();
            //ISee eagle4 = eagle;
            //Bird eagle1 = new Eagle();
            //Animal eagle2 = eagle1;

            //object eagle3 = eagle;
            //int a = 5;

            //object x = 5;
            //bool isMaried = true;
            //string word = "Hello";

            //object[] arr = { eagle, eagle1, eagle2, eagle3, a, x, isMaried, word };
            #endregion

            #region Downcasting,unboxing,explicit
            //Animal shark = new Shark();
            //Animal eagle = new Eagle();
            //Bird eagle1 = new Eagle();
            //int a = 10;
            //bool isMaried = false;
            //char letter = 'a';

            //object[] arr = { letter, shark, isMaried, eagle, a, eagle1 };
            //GetEagleSeeMethod(arr);
            //Eagle dEagle = (Eagle)eagle;

            //1 security way
            //if(eagle is Eagle)
            //{
            //    Eagle dEagle = (Eagle)eagle;
            //    dEagle.See();
            //}
            //else
            //{
            //    Console.WriteLine("Object Eagle tipi deyil");
            //}

            //2 security way
            //Eagle dEagle = eagle as Eagle;
            //if (dEagle != null)
            //{
            //    dEagle.See();
            //}
            //else
            //{
            //    Console.WriteLine("Object Eagle tipi deyil");
            //}
            #endregion

            #region Implicit,Explicit
            //Manat manat = new Manat(340);
            //Console.WriteLine(manat.Azn);
            //Dollar dollar = (Dollar)manat;
            //Console.WriteLine(dollar.Usd);
            #endregion

            //int a = 10;
            //long b = a;
            //Console.WriteLine(b);

            //long x = 10000000000;
            //int y = (int)x;
            //Console.WriteLine(y);

            //double a = 100.2143;
            //int b = (int)a;
            //Console.WriteLine(b);

            //int? a = null;
            //int b = (int)a;
            //Console.WriteLine(b);
        }

    }

    #region Implicit,Explicit
    class Manat
    {
        public double Azn { get; set; }
        public Manat(double azn)
        {
            Azn = azn;
        }

        //public static implicit operator Dollar(Manat manat)
        //{
        //    return new Dollar(manat.Azn / 1.7);
        //}


    }

    class Dollar
    {
        public double Usd { get; set; }
        public Dollar(double usd)
        {
            Usd = usd;
        }

        public static explicit operator Dollar(Manat manat)
        {
            return new Dollar(manat.Azn / 1.7);
        }
    }
    #endregion

    #region Casting
    interface ISee
    {
        void See();
    }
    abstract class Animal
    {
        public abstract void Eat();
    }

    abstract class Bird : Animal
    {
        public abstract void Fly();
    }

    class Eagle : Bird,ISee
    {
        public int Age { get; set; }
        public override void Eat()
        {
            Console.WriteLine("Eat as Eagle");
        }

        public override void Fly()
        {
            Console.WriteLine("Fly as Eagle");
        }

        public void See()
        {
            Console.WriteLine("See as Eagle");
        }
    }

    abstract class Fish : Animal
    {
        public abstract void Swim();
    }

    class Shark : Fish
    {
        public int TeethCount { get; set; }
        public override void Eat()
        {
            Console.WriteLine("Eat as Shark");
        }

        public override void Swim()
        {
            Console.WriteLine("Swim as Shark");
        }
    }
    #endregion
}
