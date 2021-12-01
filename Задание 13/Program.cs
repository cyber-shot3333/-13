using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_13
{
    class Program
     {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите адрес");
            string a = Console.ReadLine();
            Console.Write("Введите длину здания: ");
            double l = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ширину здания: ");
            double w = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите высоту здания: ");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите этажность здания: ");
            int f = Convert.ToInt32(Console.ReadLine());
            MultiBuilding multiBuilding = new MultiBuilding(a, l, w, h, f);
            multiBuilding.Print();
            Console.ReadKey();
        }
    }
    class Building
    {
        public string Adress { get; set; }
        public double lenght;
        public double width;
        public double height;
        public double Length
        {
            set
            {
                if (value > 0)
                {
                    lenght = value;
                }
                else
                {
                    Console.WriteLine("Длина здания не может быть отрицательной");
                }
            }
            get
            {
                return lenght;
            }
        }
        public double Width
        {
            set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    Console.WriteLine("Ширина здания не может быть отрицательной");
                }
            }
            get
            {
                return width;
            }
        }
        public double Height
        {
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    Console.WriteLine("Высота здания не может быть отрицательной");
                }
            }
            get
            {
                return height;
            }
        }
        public Building(string a, double l, double w, double h)
        {
            Adress = a;
            Length = l;
            Width = w;
            Height = h;
        }
        public virtual void Print()
        {
            if (lenght > 0 && width > 0 && height > 0)
            {
                Console.WriteLine("Адрес: {0}\nДлина здания: {1}\nШирина здания: {2}\nВысота здания: {3}", Adress, lenght, width, height);
            }
            else
            {
                Console.WriteLine("Введены некорректные данные, повторите попытку");
            }
        }
    }
    sealed class MultiBuilding : Building
    {
        public MultiBuilding(string a, double l, double w, double h)
           : base(a, l, w, h)
        {

        }
        public int floors;
        public int Floors
        {
            set
            {
                if (value > 0)
                {
                    floors = value;
                }
                else
                {
                    Console.WriteLine("Этажность не может быть отрицательной");
                }
            }
            get
            {
                return floors;
            }
        }
        public MultiBuilding(string a, double l, double w, double h, int f)
            : base(a, l, w, h)
        {
            if (f > 0)
            {
                Floors = f;
            }
            else
            {
                Console.WriteLine("Этажность не может быть отрицательной");
            }

        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Колличество этажей: {0}", Floors);
        }
    }
}
