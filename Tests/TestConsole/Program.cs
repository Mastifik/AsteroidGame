﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Player player1 = new Player();
            player1.Name = "Иванов";
            player1.Birthday = new DateTime(1974, 12, 21, 0, 0, 0);
            */
                       
            /*Player player1 = new Player("Emrty", new DateTime(1987, 12, 12));

            Console.Write("Введите фамилию >");
            player1.Name = Console.ReadLine();

            Console.WriteLine(player1.GetName());
            */


            var v1 = new Vector2D(5, 7);
            var v2 = new Vector2D(-7, 2);

            var v3 = v1 + v2;

            var v4 = v3 + 3.14159265358979;

            double pi = 3.1515;
            int i = (int)pi;

            double Length = v4;

            Console.ReadLine();
        }
    }
}
