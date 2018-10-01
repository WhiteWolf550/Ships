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
            //Ships ship = new Ships();
            string xs;
            string ys;
            string hitxs;
            string hitys;
            Console.WriteLine("Pole Player1:");
            pole.BaseSea();
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
            Console.WriteLine(" ");
            pole.Sea(rn1x, rn1y, rn2x, rn2y, rn3x, rn3y);
            do {
                
                /*Console.WriteLine("Zadej X:");
                xs = Console.ReadLine();
                Console.WriteLine("Zadej Y:");
                ys = Console.ReadLine();
                int xr = Convert.ToInt32(xs);
                int yr = Convert.ToInt32(ys);*/
                //Console.WriteLine("xx" + xs + "xx");
                //Console.WriteLine("yy" + yr + "yy");
                Console.WriteLine("");
                // pole.state = "O";
                Console.WriteLine(rn1x + rn1y);
                Console.WriteLine("Random1-Y:" + rn1x + "X:" + rn1y);
                Console.WriteLine("Random2-Y:" + rn2y + "X:" + rn2x);
                Console.WriteLine("Random3-Y:" + rn3y + "X:" + rn3x);
                //pole.Sea(rn1x, rn1y, rn2x, rn2y, rn3x, rn3y);
                Console.WriteLine("Útočí Player2:");
                Console.WriteLine("attack Zadej X:");
                hitxs = Console.ReadLine();
                Console.WriteLine("attack Zadej Y:");
                hitys = Console.ReadLine();
                int hitx = Convert.ToInt32(hitxs);
                int hity = Convert.ToInt32(hitys);
                Console.WriteLine("X:" + hitx + "Y" + hity);
                pole.Seaattack(hity, hitx, rn1y, rn1x,rn1y, rn1x, rn2y, rn2x, rn3y, rn3x);
                Console.WriteLine("--------------------------");
                /*Console.WriteLine("Random1-Y:" + rn1x + "X:" + rn1y);
                Console.WriteLine("Random2-Y:" + rn2x + "X:" + rn2y);
                Console.WriteLine("Random3-Y:" + rn3x + "X:" + rn3y);*/
                //ship.EnemyAttack(hitx, hity, rn1x, rn1y);
            } while (5 == 5); 
        } 
        }
    }

