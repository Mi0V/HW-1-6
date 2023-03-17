using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HW_1_6
{
    class Square
    {
        public int x = 0;
        public int y = 0;

        public Square(int x,int y)
        {
            this.x = x;
            this.y = y;
        }

       

        public void full(int x, int y)
        {
            for(int i = 0; i < y; i++)
            {
                for(int j = 0; j < x; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        Write("|");
                    }
                }
                WriteLine("\n");
            }
        }
        public void Print()
        {
            WriteLine("Введите стороны квадрата: ");
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0;
            Square one;
            one = new Square(x,y);
            one.Print();
            Console.Write("Длинна: ");
            x = Int32.Parse(Console.ReadLine());
            Console.Write("Ширина: ");
            y = Int32.Parse(Console.ReadLine());
            one.full(x,y);
        }
    }
}
