using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ships {
    class Pole {
        public int size = 10;
        public string state = "L";
        public string state2 = "X";
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
        public void EnemyAttack(int hsy, int hsx, int ty, int tx, int t2y, int t2x, int t3y, int t3x) {
            if (hsy == tx && hsx == ty) {
                plocha[ty, tx] = "X";
                //Console.WriteLine(ty + tx + hsy + hsy);  ///////////////Pozor!
            }else if(hsy == t2y && hsx == t2x) {
                plocha[t2x, t2y] = "X";
            } else if (hsy == t3y && hsx == t3x) {
                plocha[t3x, t3y] = "X";
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
                    plocha[ye, xe] = "O";
                    plocha[yt, xt] = "O";
                    EnemyAttack(hy, hx, yrs, xrs, xe, ye, xt, yt);
                    Console.Write(" " + plocha[y, x]);
                }
                Console.WriteLine();
            }
        }
    }
}
