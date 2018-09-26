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
        public void EnemyAttack(int hsy, int hsx, int ty, int tx) {
            if (plocha[hsy, hsx] == plocha[ty, tx]) {
                plocha[ty, tx] = "X";
                Console.WriteLine(ty + tx + hsy + hsy);  ///////////////Pozor!
            }else {
                plocha[ty, tx] = "Z";
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
        public void Seaattack(int hy, int hx, int yrs, int xrs, int ys, int xs, int xe, int ye, int xt, int yt) {
            Console.WriteLine(" 0 1 2 3 4 5 6 7 8 9");
            for (int x = 0; x < plocha.GetLength(0); x++) {

                for (int y = 0; y < plocha.GetLength(1); y++) {

                    plocha[y, x] = state;
                    plocha[ys, xs] = "O";
                    plocha[xe, ye] = "O";
                    plocha[xt, yt] = "O";
                    EnemyAttack(hy, hx, yrs, xrs);
                    Console.Write(" " + plocha[y, x]);
                }
                Console.WriteLine();
            }
        }
    }
}
