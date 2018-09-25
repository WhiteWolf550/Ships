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
            int xs = 0;
            int ys = 0;
            //pole.plocha[0, 5] = "O";
            pole.BaseSea();
            Console.WriteLine("Zadej X:");
            xs = Console.Read();
            Console.WriteLine("Zadej Y:");
            ys = Console.Read();
            Console.WriteLine("");
            pole.Sea();
            
        } 
        }
    }

