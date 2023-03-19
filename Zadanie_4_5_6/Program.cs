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
        public string Name;
        public string Url;
        public string ip;
        public string opisanie;

        public Web_sait() { }

        public void Enter()
        {
            WriteLine("введите данные сайта для вывода пользователю");
            Write("Название ");
            Name = ReadLine();
            Write("Ссылку ");
            Url = ReadLine();
            Write("ip ");
            ip = ReadLine();
            Write("Описание сайта ");
            opisanie = ReadLine();
        }
        public void Names()
        {
            
            WriteLine($"Название сайти: {Name}");

        }
        public void Reference()
        {
            WriteLine($"Ссылка: {Url}");
        }
        public void ipp()
        {
            WriteLine($"ip: {ip}");
        }

        public void opisaniee()
        {
            WriteLine($"Описание: {opisanie}");
        }

    }
    internal class Program
    {
        

         
        static void Main(string[] args)
        {
            Web_sait web;
            web = new Web_sait();
            web.Enter();
            web.Names();
            web.Reference();
            web.ipp();
            web.opisaniee();
              
        }
    }
}
