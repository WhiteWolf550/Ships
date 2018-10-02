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
            //Ships ship = new Ships();
            string xs;
            string ys;
            string hitxs;
            string hitys;
            //Console.WriteLine("Pole Player1:");
            //pole.BaseSea();
            //Console.ReadKey();
            Random rn = new Random();

            //RANDOM PLAYER2
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
            /*Console.WriteLine("Pole Player1: ");
            pole.Player1Sea(player1rn1x, player1rn1y, player1rn2x, player1rn2y, player1rn3x, player1rn3y);
            Console.WriteLine("Pole Player2: ");
            pole.Player2Sea(player2rn1x, player2rn1y, player2rn2x, player2rn2y, player2rn3x, player2rn3y);*/
            do {
                
               
                Console.WriteLine("");
                

                
                Console.Clear();
                Console.WriteLine("Pole Player1: ");
                pole.Player1Sea(player1rn1x, player1rn1y, player1rn2x, player1rn2y, player1rn3x, player1rn3y);
                Console.WriteLine("Útočí Player2:");
                Console.WriteLine("attack Zadej X:");
                hitxs = Console.ReadLine();
                Console.WriteLine("attack Zadej Y:");
                Console.WriteLine("Random1-Y:" + player1rn1x + "X:" + player1rn1y);
                Console.WriteLine("Random2-Y:" + player1rn2x + "X:" + player1rn2y);
                Console.WriteLine("Random3-Y:" + player1rn3x + "X:" + player1rn3y);
                hitys = Console.ReadLine();

                int hitx = Convert.ToInt32(hitxs);
                int hity = Convert.ToInt32(hitys);
                Console.WriteLine("X:" + hitx + "Y" + hity);
                Console.Clear();
                pole.Player1Seaattack(hity, hitx, player1rn1y, player1rn1x, player1rn1y, player1rn1x, player1rn2y, player1rn2x, player1rn3y, player1rn3x);
                Console.WriteLine("--------------------------");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Pole Player2: ");
                pole.Player2Sea(player2rn1x, player2rn1y, player2rn2x, player2rn2y, player2rn3x, player2rn3y);
                Console.WriteLine("Útočí Player1:");
                Console.WriteLine("attack Zadej X:");
                hitxs = Console.ReadLine();
                Console.WriteLine("attack Zadej Y:");
                hitys = Console.ReadLine();
                int hitx2 = Convert.ToInt32(hitxs);
                int hity2 = Convert.ToInt32(hitys);
                Console.WriteLine("X:" + hitx2 + "Y" + hity2);
                Console.WriteLine("Pole Player2: ");
                pole.Player2Seaattack(hity2, hitx2, player2rn1y, player2rn1x, player2rn1y, player2rn1x, player2rn2y, player2rn2x, player2rn3y, player2rn3x);
                Console.WriteLine("Random1-Y:" + player1rn1x + "X:" + player1rn1y);
                Console.WriteLine("Random2-Y:" + player1rn2x + "X:" + player1rn2y);
                Console.WriteLine("Random3-Y:" + player1rn3x + "X:" + player1rn3y);
                //ship.EnemyAttack(hitx, hity, rn1x, rn1y);*/
            } while (5 == 5); 
        } 
        }
    }

