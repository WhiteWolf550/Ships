using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ships {
    class Program {
        static void Main(string[] args) {

            bool game = true;

            int winner = 0;

            //VYTVOŘENÍ POLE PRO PLAYER1.....
            Pole Pole1 = new Pole();

            bool shipSelection1 = true;


            Console.WriteLine("Vítejte ve hře lodě!");
            Console.WriteLine("Lodě začíná pokládat Player1!");
            Console.WriteLine("<<Pro pokračování stiskni libovolnou klávesu>>");
            Console.ReadKey();
            Pole1.CreateShip();

            while (shipSelection1 && Pole1.Restric) {

                Console.Clear();

                shipSelection1 = Pole1.IsShipSelection();
                Console.WriteLine("1 2 3 4 5 6 7 8 9 10");
                Pole1.GeneratePole();

                Pole1.MoveBoat();

                //Pole1.AllCreatedFields();

            }

            //VYTVOŘENÍ POLE PRO PLAYER2.....
            Pole Pole2 = new Pole();

            bool shipSelection2 = true;

            Console.Clear();
            Console.WriteLine("Lodě pokládá Player2!");
            Console.WriteLine("<<Pro pokračování stiskni libovolnou klávesu>>");
            Console.ReadKey();

            Pole2.CreateShip();



            while (shipSelection2 && Pole2.Restric) {
                Console.Clear();

                shipSelection2 = Pole2.IsShipSelection();

                Pole2.GeneratePole();

                Pole2.MoveBoat();


            }

            //MAIN GAME...

            bool player1 = true;
            bool player2 = false;


            while (game) {
                Console.WriteLine("Teď střílí Player1...");
                Console.WriteLine("<<Pro pokračování stiskni libovolnou klávesu>>");
                Console.ReadKey();
                while (player1) {
                    Console.WriteLine("Vyberte pole pomoci sipek a potvrdte klavesou 'Enter' ");
                    Console.WriteLine("Pole Player2...");
                    Console.WriteLine();
                    Pole2.GeneratePoleShoot();
                    Pole2.Shoot();
                    Console.Clear();
                    if (Pole2.Hit) {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Dobrá práce, sestřelil jsi loď!!!");
                        Console.ForegroundColor = ConsoleColor.White;
                        player1 = true;
                        player2 = false;
                    }
                    else {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Škoda, žadnou loď jsi netrefil, možná budeš mít víc štěstí příště.. ");
                        Console.ForegroundColor = ConsoleColor.White;
                        player1 = false;
                        player2 = true;
                    }
                    //KONTROLA JESTLI VYHRAL PLAYER2
                    if (Pole2.IsWinner()) {
                        game = false;
                        player1 = false;
                        player2 = false;
                        winner = 1;
                    }
                }
                Console.WriteLine("Teď střílí Player2...");
                Console.WriteLine("<<Pro pokračování stiskni libovolnou klávesu>>");
                Console.ReadKey();
                while (player2) {
                    Console.Write("Vyberte pole pomoci sipek a potvrdte klavesou 'Enter' ");
                    Console.Write("Pole Player1...");
                    Console.WriteLine();
                    Pole1.GeneratePoleShoot();
                    Pole1.Shoot();
                    Console.Clear();
                    if (Pole1.Hit) {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Dobrá práce, sestřelil jsi loď!!!");
                        Console.ForegroundColor = ConsoleColor.White;
                        player1 = false;
                        player2 = true;
                    }
                    else {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Škoda, žadnou loď jsi netrefil, možná budeš mít víc štěstí příště.. ");
                        Console.ForegroundColor = ConsoleColor.White;
                        player1 = true;
                        player2 = false;
                    }
                    //KONTROLA JESTLI VYHRAL PLAYER1....
                    if (Pole1.IsWinner()) {
                        game = false;
                        player1 = false;
                        player2 = false;
                        winner = 2;
                    }
                }
            }

            // VYPIS VYTEZE PLAYER1 NEBO PLAYER2.........
            Console.Clear();

            if (winner == 1) {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Player 1 vyhral!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (winner == 2) {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Player 2 vyhral!");
                Console.ForegroundColor = ConsoleColor.White;
            }
        } 
        }
    }

