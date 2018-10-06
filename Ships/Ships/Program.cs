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
            Ships ships = new Ships();
            //Ships ship = new Ships();
            string xs;
            string ys;
            string hitxs;
            string hitys;
            bool choose = true;
            bool choose2 = true;
            bool game = true;
            //Console.WriteLine("Pole Player1:");
            //pole.BaseSea();
            //Console.ReadKey();
            Random rn = new Random();

            //RANDOM PLAYER1
            int player1rn1x = rn.Next(0, 10);
            int player1rn1y = rn.Next(0, 10);
            int player1rn2x = rn.Next(0, 10);
            int player1rn2y = rn.Next(0, 10);
            int player1rn3x = rn.Next(0, 10);
            int player1rn3y = rn.Next(0, 10);

            //RANDOM PLAYER2
            int player2rn1x = rn.Next(0, 10);
            int player2rn1y = rn.Next(0, 10);
            int player2rn2x = rn.Next(0, 10);
            int player2rn2y = rn.Next(0, 10);
            int player2rn3x = rn.Next(0, 10);
            int player2rn3y = rn.Next(0, 10);
            Console.WriteLine(" ");

            //VÝBĚR ROZMÍSTĚNÍ LODÍ PLAYER1..........
            do {
                Console.Clear();
                Console.Write("Pole ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Player1");
                Console.ForegroundColor = ConsoleColor.White;
                pole.Player1Sea(player1rn1x, player1rn1y, player1rn2x, player1rn2y, player1rn3x, player1rn3y);
                Console.WriteLine("Chceš tohle rozmístění lodí ponechat, nebo chceš nové?");
                Console.WriteLine("1]Nové rozmístění \n" +
                    "2]Pokračovat");
                string choice = Console.ReadLine();
                int choi = Convert.ToInt32(choice);

                if(choi == 1) {
                    player1rn1x = rn.Next(0, 10);
                    player1rn1y = rn.Next(0, 10);
                    player1rn2x = rn.Next(0, 10);
                    player1rn2y = rn.Next(0, 10);
                    player1rn3x = rn.Next(0, 10);
                    player1rn3y = rn.Next(0, 10);

                }
                else if(choi == 2) {
                    choose = false;
                } else {
                    Console.WriteLine("Můžeš zadat jen 1 nebo 2!!");
                }

            } while (choose == true);

            //VÝBĚR ROZMÍSTĚNÍ LODÍ PLAYER2........
            do {
                Console.Clear();
                Console.Write("Pole ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Player2");
                Console.ForegroundColor = ConsoleColor.White;
                pole.Player2Sea(player2rn1x, player2rn1y, player2rn2x, player2rn2y, player2rn3x, player2rn3y);
                Console.WriteLine("Chceš tohle rozmístění lodí ponechat, nebo chceš nové?");
                Console.WriteLine("1]Nové rozmístění \n" +
                    "2]Pokračovat");
                string choice2 = Console.ReadLine();
                int choi2 = Convert.ToInt32(choice2);

                if (choi2 == 1) {
                    player2rn1x = rn.Next(0, 10);
                    player2rn1y = rn.Next(0, 10);
                    player2rn2x = rn.Next(0, 10);
                    player2rn2y = rn.Next(0, 10);
                    player2rn3x = rn.Next(0, 10);
                    player2rn3y = rn.Next(0, 10);

                }
                else if (choi2 == 2) {
                    choose2 = false;
                }
                else {
                    Console.WriteLine("Můžeš zadat jen 1 nebo 2!!");
                }

            } while (choose2 == true);


            //HRA...
            do {

                Console.ReadKey();
                Console.WriteLine("");
                Console.Write("Útočí ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Player2");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Pro pokračování stiskni libovolnou klávesu");
                Console.ReadKey();


                Console.Clear();

                //HRAJE HRÁČ 2.....
                Console.Write("Pole ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Player1");
                Console.ForegroundColor = ConsoleColor.White;
                pole.Player1Sea(player1rn1x, player1rn1y, player1rn2x, player1rn2y, player1rn3x, player1rn3y);
                Console.Write("Útočí ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Player2");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("attack Zadej X:");
                hitxs = Console.ReadLine();
                Console.WriteLine("attack Zadej Y:");
                /*Console.WriteLine("Random1-Y:" + player1rn1x + "X:" + player1rn1y);
                Console.WriteLine("Random2-Y:" + player1rn2x + "X:" + player1rn2y);
                Console.WriteLine("Random3-Y:" + player1rn3x + "X:" + player1rn3y);*/
                hitys = Console.ReadLine();
                int hitx = Convert.ToInt32(hitxs);
                int hity = Convert.ToInt32(hitys);
                Console.WriteLine("X:" + hitx + "Y" + hity);
                Console.Clear();
                Console.Write("Pole ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Player1");
                Console.ForegroundColor = ConsoleColor.White;
                pole.Player1Seaattack(hity, hitx, player1rn1y, player1rn1x, player1rn1y, player1rn1x, player1rn2y, player1rn2x, player1rn3y, player1rn3x);
                Console.WriteLine("--------------------------");
                if (pole.player1_ships_destroyed == 300) {
                    Console.Write("HRU VYHRÁL ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Player2 ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Gratulace!!");
                    game = true;
                    Environment.Exit(-1);
                }
                else if (pole.player2_ships_destroyed == 3) {
                    Console.Write("HRU VYHRÁL ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Player1 ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Gratulace!!");
                    game = true;
                    Environment.Exit(-1);
                }
                Console.Write("Útočí ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Player1");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Pro pokračování stiskni libovolnou klávesu");
                Console.ReadKey();
                Console.Clear();
                
                //HRAHE HRÁČ 1....
                Console.Write("Pole ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Player2");
                Console.ForegroundColor = ConsoleColor.White;
                pole.Player2Sea(player2rn1x, player2rn1y, player2rn2x, player2rn2y, player2rn3x, player2rn3y);
                Console.Write("Útočí ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Player1");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("attack Zadej X:");
                hitxs = Console.ReadLine();
                Console.WriteLine("attack Zadej Y:");
                hitys = Console.ReadLine();
                int hitx2 = Convert.ToInt32(hitxs);
                int hity2 = Convert.ToInt32(hitys);
                Console.WriteLine("X:" + hitx2 + "Y" + hity2);
                Console.Clear();
                Console.Write("Pole ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Player2");
                Console.ForegroundColor = ConsoleColor.White;
                pole.Player2Seaattack(hity2, hitx2, player2rn1y, player2rn1x, player2rn1y, player2rn1x, player2rn2y, player2rn2x, player2rn3y, player2rn3x);
                Console.WriteLine("--------------------------");
                
                if (pole.player1_ships_destroyed == 300) {
                    game = false;
                    Console.Write("HRU VYHRÁL ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Player2 ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Gratulace!!");
                }
                else if (pole.player2_ships_destroyed == 300) {
                    game = false;
                    Console.Write("HRU VYHRÁL ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Player1 ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Gratulace!!");

                }
                
                
                
            } while (game == true); 
        } 
        }
    }

