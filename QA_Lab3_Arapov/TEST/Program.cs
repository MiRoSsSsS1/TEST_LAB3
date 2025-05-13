using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    class Otrezok
    {
        public Otrezok()
        {
            x1 = 1;
            y1 = 2;
            x2 = 3;
            y2 = 4;
        }
        public Otrezok(double a, double b, double c, double d)
        {
            x1 = a;
            y1 = b;
            x2 = c;
            y2 = d;
        }
        public void Init(double a, double b, double c, double d)
        {
            x1 = a;
            y1 = b;
            x2 = c;
            y2 = d;
        }
        public virtual double Len()
        {
            return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        }
        public Otrezok Add(Otrezok e, Otrezok f)
        {
            Otrezok g = new Otrezok();
            g.Init(e.x1, e.y1, f.x2, f.y2);
            return g;
        }
        public virtual void Read()
        {
            Console.Write("Введите координату x1:");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату y1:");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату x2:");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату y2:");
            y2 = Convert.ToDouble(Console.ReadLine());
        }
        public virtual void Display()
        {
            Console.Write("Координаты отрезка: ");
            Console.WriteLine("( " + x1 + " ; " + y1 + " ) " + ";" + " ( " + x2 + " ; " + y2 + " ) ");
        }

        protected double x1;
        protected double y1;
        protected double x2;
        protected double y2;
        public double X1
        {
            get { return x1; }
            set { x1 = value; }
        }
    }
    class ParPlos : Otrezok
    {
        private double z1;
        public ParPlos() : base()
        {
            z1 = 5;
        }
        public ParPlos(double a, double b, double c, double d, double z) : base(a, b, c, d)
        {
            z1 = z;
        }
        public void Init(double a, double b, double c, double d, double z)
        {
            base.Init(a, b, c, d);
            z1 = z;
        }

        public override double Len()
        {
            return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)) + z1;
        }
        public override void Read()
        {
            base.Read();
            Console.Write("Введите расстояние до плоскости: ");
            z1 = Convert.ToDouble(Console.ReadLine());
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Расстояние между плоскостями: " + z1);
        }

        public void Putz(double z)
        {
            z1 = z;
        }
        public double Getz()
        {
            return z1;
        }
    }
    class Programm
    {
        static void Main(String[] args)
        {
            Otrezok o1, o2, o3;
            o1 = new Otrezok();
            o2 = new Otrezok(1, 2, 3, 4);
            o3 = new Otrezok();
            o1.Init(5, 6, 7, 8);
            o3.Read();
            o1.Display();
            o2.Display();
            o3.Display();
            double l1, l2;
            l1 = o1.Len();
            l2 = o2.Len();
            Console.WriteLine("Длина первого отрезка: " + l1);
            Console.WriteLine("Длина второго отрезка: " + l2);

            ParPlos p1, p2, p3;
            p1 = new ParPlos();
            p2 = new ParPlos(11, 12, 13, 14, 15);
            p3 = new ParPlos();
            p1.Init(1, 2, 3, 4, 5);
            p3.Read();
            p1.Display();
            p2.Display();
            double k1, k2;
            Console.WriteLine("Расстояние между плоскостями изначальное: " + p1.Getz());
            p1.Putz(105);
            Console.WriteLine("Расстояние между плоскостями после присваивания нового z: " + p1.Getz());
            p1.Display();
            k1 = p1.Len();
            k2 = p2.Len();
            Console.WriteLine("Длина первого отрезка + расстояние до плоскости: " + k1);
            Console.WriteLine("Длина второго отрезка + расстояние до плоскости: " + k2);
            Console.ReadKey();
        }
    }
}


