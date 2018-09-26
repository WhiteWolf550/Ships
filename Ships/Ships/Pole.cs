using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ships {
    class Pole {
        public int size = 10;
        public string state = "L";
        public string[,] plocha = new string[10, 10];
        Ships lod = new Ships();
        public void BaseSea()
        {
            Console.WriteLine(" 0 1 2 3 4 5 6 7 8 9");
            for (int x = 0; x < plocha.GetLength(0); x++)
            {

                for (int y = 0; y < plocha.GetLength(1); y++)
                {
                    plocha[y, x] = "L";
                    //Ship();
                    Console.Write(" " + plocha[y, x]);
                }
                Console.WriteLine();
            }
        }
        public void Sea(int xs, int ys, int xe, int ye, int xt, int yt)
        {
            Console.WriteLine(" 0 1 2 3 4 5 6 7 8 9");
            for (int x = 0; x < plocha.GetLength(0); x++)
            {

                for (int y = 0; y < plocha.GetLength(1); y++)
                {

                    plocha[y, x] = state;
                    plocha[ys, xs] = "O";
                    plocha[xe, ye] = "O";
                    plocha[xt, yt] = "O";
                    Console.Write(" " + plocha[y, x]);
                }
                Console.WriteLine();
            }
        }
    }
}
