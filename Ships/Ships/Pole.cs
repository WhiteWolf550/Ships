using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ships {
    class Pole {
        public int size = 10;
        public string[,] plocha = new string[10, 10];
        public void Sea()
        {
            for (int x = 0; x < plocha.GetLength(0); x++)
            {

                for (int y = 0; y < plocha.GetLength(1); y++)
                {
                    plocha[x, y] = "L";
                    plocha[6, 5] = "O";
                    plocha[1, 1] = "O";
                    plocha[9, 9] = "O";
                    plocha[9, 8] = "O";
                    //Ship();
                    Console.Write(" " + plocha[x, y]);
                }
                Console.WriteLine();
            }
        }
        public void Ship()
        {
            Console.WriteLine("Zadej X:");
            int getx = Console.ReadKey().KeyChar;
            Console.WriteLine("Zadej Y:");
            int gety = Console.ReadKey().KeyChar;
            plocha[getx, gety] = "0";
        }
    }
}
