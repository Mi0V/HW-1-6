using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Array;

namespace Polyndrom
{
    class Polyndrome
    {
        
        public Polyndrome()
        {
            
        }
        

        public void Print()
        {
            WriteLine("Заполните значение массива:");
            int number = 0, reverse = 0;
            number = Int32.Parse(ReadLine());
            int buffer = number;
            while (buffer > 0)
            {
                reverse *= 10;
                reverse += buffer % 10;
                buffer /= 10;
            }
            if (reverse == number)
            {
                Write("Polydrome!");
            }
            else
            {
                Write("Not Polydrome!");
            }
        }

        public void arr()
        {
            
            //for (int i = 0, j = 4; i < Arr.Length; i++, j--)
            //{
            //    Arr[i] = Int32.Parse(Console.ReadLine());
            //    Arrn[j] = Arr[i];

            //}
            //for (int i = 0; i < Arr.Length; i++)
            //{ 
            //    Write($"{Arr[i]}");
            //}
            //Write($" : ");
            //for (int i = 0; i < Arr.Length; i++)
            //{ 
            //    Write($"{Arrn[i]}");
            //}

            //for(int i = 0; i < Arr.Length; i++)
            //{
            //    if(Arr[i] == Arrn[i])
            //    {
            //        Write("Полиндром");

            //    }
            //    else
            //    {
            //        Write("Не полиндром");
            //    }    
            //}





        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {

            Polyndrome all;
            all = new Polyndrome();
            all.Print();

            //int number = 5;
            //int[] myArray = new int[number];
            //int[] myArray2 = new int[number];
            //WriteLine("Введите 5 чисeл: ");
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    myArray[i] = Int32.Parse(ReadLine());
            //}
            //myArray2 = myArray;
            //for(int i = 5, j = 0; i > 0; i--, j++)
            //{
            //    myArray2[j] = myArray[i];
            //}
            //WriteLine(myArray[3]);
            //WriteLine(myArray2[3]);
           
            
            
        }
    }
}
