using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ships {
    class Program {
        static void Main(string[] args) {

            Pole pole = new Pole();
            Player player = new Player();
            Ships ship = new Ships();
            string xs;
            string ys;
            pole.BaseSea();
            do {
                Random rn = new Random();
                int rn1x = rn.Next(0, 10);
                int rn1y = rn.Next(0, 10);
                int rn2x = rn.Next(0, 10);
                int rn2y = rn.Next(0, 10);
                int rn3x = rn.Next(0, 10);
                int rn3y = rn.Next(0, 10);
                int rn4x = rn.Next(0, 10);
                int rn4y = rn.Next(0, 10);
                int rn5x = rn.Next(0, 10);
                int rn5y = rn.Next(0, 10);
                Console.WriteLine("Zadej X:");
                xs = Console.ReadLine();
                Console.WriteLine("Zadej Y:");
                ys = Console.ReadLine();
                int xr = Convert.ToInt32(xs);
                int yr = Convert.ToInt32(ys);
                //Console.WriteLine("xx" + xs + "xx");
                //Console.WriteLine("yy" + yr + "yy");
                Console.WriteLine("");
                // pole.state = "O";
                pole.Sea(rn1x, rn1y, rn2x, rn2y, rn3x, rn3y);
                ship.EnemyAttack(rn1x, rn1y, rn2x, rn2y, rn3x, rn3y);
            } while (5 == 5); 
        } 
        }
    }

