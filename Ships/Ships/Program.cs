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
            int xs = 0;
            int ys = 0;
            //pole.plocha[0, 5] = "O";
            pole.Sea();
            /*var command = Console.ReadKey().Key;
            switch (command)
            {
                case ConsoleKey.DownArrow:
                    ys++;
                    pole.plocha[xs, ys] = "O";
                    break;
                case ConsoleKey.UpArrow:
                    if (ys > 0)
                    {
                        ys--;
                        pole.plocha[xs, ys] = "O";
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (xs > 0)
                    {
                        xs--;
                        pole.plocha[xs, ys] = "O";
                    }
                    break;
                case ConsoleKey.RightArrow:
                    xs++;
                    pole.plocha[xs, ys] = "O";
                    break;
            }*/
        } 
        }
    }

