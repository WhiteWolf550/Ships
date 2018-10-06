using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ships {
    class Pole {
        public int size = 10;
        public string state = "L";
        bool Player1hlp1 = false;
        bool Player1hlp2 = false;
        bool Player1hlp3 = false;

        bool Player2hlp1 = false;
        bool Player2hlp2 = false;
        bool Player2hlp3 = false;
        public int player1_ships_destroyed = 0;
        public int player2_ships_destroyed = 0;
        string hitmes = "";
        public string[,] plocha = new string[10, 10];
        public void BaseSea()
        {
            Console.WriteLine(" 0 1 2 3 4 5 6 7 8 9");
            for (int x = 0; x < plocha.GetLength(0); x++)
            {

                for (int y = 0; y < plocha.GetLength(1); y++)
                {
                    plocha[y, x] = "L";
                    Console.Write(" " + plocha[y, x]);
                }
                Console.WriteLine();
            }
        }

        //KDYŽ ÚTOČÍ PLAYER2..............
        public void Player2Attack(int hsy, int hsx, int ty, int tx, int t2y, int t2x, int t3y, int t3x) {
            if (hsy == tx && hsx == ty) {
                plocha[ty, tx] = "X";
                hitmes = "Trefil jsi loď! Dobrá práce!";
                player1_ships_destroyed++;
                Player1hlp1 = true;
            }else if(hsy == t2y && hsx == t2x) {
                plocha[t2x, t2y] = "X";
                hitmes = "Trefil jsi loď!Dobrá práce!";
                player1_ships_destroyed++;
                Player1hlp2 = true;
                
            } else if (hsy == t3y && hsx == t3x) {
                plocha[t3x, t3y] = "X";
                hitmes = "Trefil jsi loď! Dobrá práce!";
                player1_ships_destroyed++;
                Player1hlp3 = true;
            }else {
                hitmes = "Škoda žádnou loď jsi netrefil, možná příště!";
            }

            
        }

        //KDYŽ ÚTOČÍ PLAYER1.........
        public void Player1Attack(int hsy, int hsx, int ty, int tx, int t2y, int t2x, int t3y, int t3x) {
            if (hsy == tx && hsx == ty) {
                plocha[ty, tx] = "X";
                hitmes = "Trefil jsi loď! Dobrá práce!";
                player2_ships_destroyed++;
                Player2hlp1 = true;
            }
            else if (hsy == t2y && hsx == t2x) {
                plocha[t2x, t2y] = "X";
                hitmes = "Trefil jsi loď! Dobrá práce!";
                player2_ships_destroyed++;
                Player2hlp2 = true;

            }
            else if (hsy == t3y && hsx == t3x) {
                plocha[t3x, t3y] = "X";
                hitmes = "Trefil jsi loď! Dobrá práce!";
                player2_ships_destroyed++;
                Player2hlp3 = true;
            }
            else {
                hitmes = "Škoda žádnou loď jsi netrefil, možná příště!";
            }
        }
            
            //POLE PLAYER1.......
            public void Player1Sea(int xs, int ys, int xe, int ye, int xt, int yt)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" 0 1 2 3 4 5 6 7 8 9");
            Console.ForegroundColor = ConsoleColor.White;
            for (int x = 0; x < plocha.GetLength(0); x++)
            {

                for (int y = 0; y < plocha.GetLength(1); y++)
                {

                    plocha[y, x] = state;
                    plocha[ys, xs] = "O";
                    plocha[xe, ye] = "O";
                    plocha[xt, yt] = "O";
                    if (Player1hlp1 == true) {
                        plocha[ys, xs] = "X";
                    }
                    if (Player1hlp2 == true) {
                        plocha[xe, ye] = "X";
                    }
                    if (Player1hlp3 == true) {
                        plocha[xt, yt] = "X";
                    }
                    Console.Write(" " + plocha[y, x]);
                }
                Console.WriteLine();
            }
        }

        //POLE PLAYER2..............
        public void Player2Sea(int xs, int ys, int xe, int ye, int xt, int yt) {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" 0 1 2 3 4 5 6 7 8 9");
            Console.ForegroundColor = ConsoleColor.White;
            for (int x = 0; x < plocha.GetLength(0); x++) {

                for (int y = 0; y < plocha.GetLength(1); y++) {

                    plocha[y, x] = state;
                    plocha[ys, xs] = "O";
                    plocha[xe, ye] = "O";
                    plocha[xt, yt] = "O";
                    if (Player2hlp1 == true) {
                        plocha[ys, xs] = "X";
                    }
                    if (Player2hlp2 == true) {
                        plocha[xe, ye] = "X";
                    }
                    if (Player2hlp3 == true) {
                        plocha[xt, yt] = "X";
                    }
                    Console.Write(" " + plocha[y, x]);
                }
                Console.WriteLine();
            }
        }
        //POLE PLAYER1 PO ÚTOKU.........
        public void Player1Seaattack(int hy, int hx, int yrs, int xrs, int ys, int xs, int xe, int ye, int xt, int yt) {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" 0 1 2 3 4 5 6 7 8 9");
            Console.ForegroundColor = ConsoleColor.White;
            for (int x = 0; x < plocha.GetLength(0); x++) {

                for (int y = 0; y < plocha.GetLength(1); y++) {

                    plocha[y, x] = state;
                    plocha[ys, xs] = "O";
                    plocha[ye, xe] = "O";
                    plocha[yt, xt] = "O";
                    if (Player1hlp1 == true) {
                        plocha[ys, xs] = "X";
                        
                    }
                    if (Player1hlp2 == true) {
                        plocha[ye, xe] = "X";
                        
                    }
                    if(Player1hlp3 == true) {
                        plocha[yt, xt] = "X";
                        
                    }
                    Player2Attack(hy, hx, yrs, xrs, xe, ye, xt, yt);
                    Console.Write(" " + plocha[y, x]);
                }
                Console.WriteLine();
                
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(hitmes);
            Console.ForegroundColor = ConsoleColor.White;
        }

        //POLE PLAYER2 PO ÚTOKU................
        public void Player2Seaattack(int hy, int hx, int yrs, int xrs, int ys, int xs, int xe, int ye, int xt, int yt) {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" 0 1 2 3 4 5 6 7 8 9");
            Console.ForegroundColor = ConsoleColor.White;
            for (int x = 0; x < plocha.GetLength(0); x++) {

                for (int y = 0; y < plocha.GetLength(1); y++) {

                    plocha[y, x] = state;
                    plocha[ys, xs] = "O";
                    plocha[ye, xe] = "O";
                    plocha[yt, xt] = "O";
                    if (Player2hlp1 == true) {
                        plocha[ys, xs] = "X";
                        
                    }
                    if (Player2hlp2 == true) {
                        plocha[ye, xe] = "X";
                        
                    }
                    if (Player2hlp3 == true) {
                        plocha[yt, xt] = "X";
                        
                    }
                    Player1Attack(hy, hx, yrs, xrs, xe, ye, xt, yt);
                    Console.Write(" " + plocha[y, x]);
                }
                Console.WriteLine();

            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(hitmes);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
