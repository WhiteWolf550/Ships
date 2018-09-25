using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ships {
    class Pole {
        public int size = 10;
        public string[,] plocha = new string[10, 10];
        int xs = 3;
        int ys = 3;
        /*public void BaseSea()
        {
            for (int x = 0; x < plocha.GetLength(0); x++)
            {

                for (int y = 0; y < plocha.GetLength(1); y++)
                {
                    plocha[x, y] = "L";
                    //Ship();
                    Console.Write(" " + plocha[x, y]);
                }
                Console.WriteLine();
            }
        }*/
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
                    plocha[xs, ys] = "O";
                    //Ship();
                    Console.Write(" " + plocha[x, y]);
                }
                Console.WriteLine();
            }
        }
    }
}
