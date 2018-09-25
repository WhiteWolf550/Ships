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
                Console.WriteLine("Zadej X:");
                xs = Console.ReadLine();
                Console.WriteLine("Zadej Y:");
                ys = Console.ReadLine();
                int xr = Convert.ToInt32(xs);
                int yr = Convert.ToInt32(ys);
                //Console.WriteLine("xx" + xs + "xx");
                //Console.WriteLine("yy" + yr + "yy");
                Console.WriteLine("");
                pole.Sea(xr, yr);
            } while (5 == 5); 
        } 
        }
    }

