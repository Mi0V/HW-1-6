using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Zadanie_4_5_6
{
    class Web_sait
    {

        static void Name()
        {

            WriteLine("***********MVideo**********");
        }
        static void Reference()
        {
            WriteLine("//http.MVideo.ru");
        }
        static void ip()
        {
            WriteLine("191.168.25.0.1");
        }

        static void opisanie()
        {
            WriteLine("Официальный сайт магазина MVideo");
        }

    }
    internal class Program
    {
        

         
        static void Main(string[] args)
        {
            Web_sait web;
            web = new Web_sait();
            web.Name();
            web.Reference();
            web.ip();
            web.opisanie();
              
        }
    }
}
