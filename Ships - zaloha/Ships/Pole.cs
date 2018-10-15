using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ships {
    class Pole {
        //VELIKOST POLE........
        public int SizeX = 10;
        public int SizeY = 10;
        //

        public bool MoveShip = true;
        private int boatID = 0;

        public bool Hit = false;
        public bool Restric = true;

        private bool ponorka = true;
        private bool torpedoborec = true;
        private bool kriznik = true;
        private bool bitevniLod = true;
        private bool letadlovaLod = true;
        private bool pristavaciZakladna = true;
        private bool hydroplan = true;
        private bool kriznikII = true;
        private bool tezkyKriznik = true;
        private bool katamaran = true;
        private bool lehkaBitevniLod = true;
        private bool letadlovaLodII = true;
        private bool parnik = true;

        private Field scope = new Field {
            X = 1,
            Y = 1,
            Type = 2
        };

        //JIŽ VYBRANÉ LODĚ......
        public List<int> selectedBoats = new List<int>();

        private List<Field> createdFields = new List<Field>();
        private List<Field> shotFields = new List<Field>();
        //LODĚ
        private List<Ships> ships = new List<Ships>();

        //PRÁZDNÉ POLE.......
        private List<Field> createMap() {
            List<Field> fields = new List<Field>();
            //Y
            for (int i = 1; i <= SizeY; i++) {
                //X
                for (int j = 1; j <= SizeX; j++) {
                    fields.Add(new Field {
                        X = j,
                        Y = i
                    });
                }
            }
            return fields;
        }

        //POLE........
        public void AddField(int x, int y, int type) {
            createdFields.Add(new Field {
                X = x,
                Y = y,
                Type = type
            });
        }

        //PŘEVEDENÍ LODÍ NA POLE...
        private void shipToFields(List<Field> ship) {
            foreach (Field shipField in ship) {
                AddField(shipField.X, shipField.Y, 1);
            }
        }

        //PŘIDÁNÍ LODÍ...
        public void CreateShip() {
            //Console.ReadKey();
            Console.Clear();

            List<Field> ship = new List<Field>();

            bool shipCreated = true;
            bool correctChose = false;

            if (!IsShipSelection()) {
                correctChose = true;
                shipCreated = false;
            }

            while (!correctChose) {
                Console.WriteLine("1-Ponorka");
                Console.WriteLine("2.Torpédoborec");
                Console.WriteLine("3-Křižník");
                Console.WriteLine("4-Bitevní loď");
                Console.WriteLine("5-Letadlová loď");
                Console.WriteLine("6-Přistávací základna");
                Console.WriteLine("7-Hydroplan");
                Console.WriteLine("8-Křižník typ 2");
                Console.WriteLine("9-Těžký křižník");
                Console.WriteLine("10-Katamaran");
                Console.WriteLine("11-Lehká bitevní loď");
                Console.WriteLine("12-Letadlová loď typ 2");
                Console.WriteLine("13-Parník");


                int type = 0;

                bool chose = true;
                while (chose) {
                    if (selectedBoats.Count != 0) {
                        Console.Write("Vybrane lode: ");
                        foreach (int selectedBoat in selectedBoats) {
                            Console.Write("{0} ", selectedBoat);
                        }
                    }

                    Console.WriteLine();
                    //Console.Write("Vyberte lod: ");
                    Random random = new Random();

                    try {
                        //int key = Convert.ToInt32(Console.ReadLine());
                        int key = random.Next(1, 13);
                        type = key;
                        chose = false;
                    }
                    catch (FormatException) {
                        Console.WriteLine("Spatne zadany typ lode");
                    }
                }

                //PONORKA...........
                if (type == 1 && ponorka) {
                    for (int i = 0; i < 1; i++) {
                        ship.Add(new Field { X = 1 + i, Y = 1, Type = 1 });
                    }
                    ponorka = false;
                    correctChose = true;
                    selectedBoats.Add(1);
                }
                //TORPEDOBOREC..........
                else if (type == 2 && torpedoborec) {
                    for (int i = 0; i < 2; i++) {
                        ship.Add(new Field { X = 1 + i, Y = 1, Type = 1 });
                    }
                    torpedoborec = false;
                    correctChose = true;
                    selectedBoats.Add(2);
                }
                //KŘIŽNÍK......
                else if (type == 3 && kriznik) {
                    for (int i = 0; i < 3; i++) {
                        ship.Add(new Field { X = 1 + i, Y = 1, Type = 1 });
                    }
                    kriznik = false;
                    correctChose = true;
                    selectedBoats.Add(3);
                }
                //BITEVNÍ LOĎ.......
                else if (type == 4 && bitevniLod) {
                    for (int i = 0; i < 4; i++) {
                        ship.Add(new Field { X = 1 + i, Y = 1, Type = 1 });
                    }
                    bitevniLod = false;
                    correctChose = true;
                    selectedBoats.Add(4);
                }
                //LETADLOVKA......
                else if (type == 5 && letadlovaLod) {
                    for (int i = 0; i < 5; i++) {
                        ship.Add(new Field { X = 1 + i, Y = 1, Type = 1 });
                    }
                    letadlovaLod = false;
                    correctChose = true;
                    selectedBoats.Add(5);
                }
                //ZAKLADNA..............
                else if (type == 6 && pristavaciZakladna) {
                    for (int i = 0; i < 3; i++) {
                        ship.Add(new Field { X = 1 + i, Y = 1, Type = 1 });
                    }
                    for (int i = 0; i < 3; i++) {
                        ship.Add(new Field { X = 1 + i, Y = 2, Type = 1 });
                    }
                    pristavaciZakladna = false;
                    correctChose = true;
                    selectedBoats.Add(6);
                }
                //HYDROPLAN............
                else if (type == 7 && hydroplan) {
                    ship.Add(new Field { X = 1, Y = 2, Type = 1 });
                    ship.Add(new Field { X = 2, Y = 1, Type = 1 });
                    ship.Add(new Field { X = 3, Y = 2, Type = 1 });
                    hydroplan = false;
                    correctChose = true;
                    selectedBoats.Add(7);
                }
                //KŘIŽNÍK TYP 2...............
                else if (type == 8 && kriznikII) {
                    ship.Add(new Field { X = 1, Y = 2, Type = 1 });
                    ship.Add(new Field { X = 2, Y = 1, Type = 1 });
                    ship.Add(new Field { X = 2, Y = 2, Type = 1 });
                    ship.Add(new Field { X = 3, Y = 2, Type = 1 });
                    kriznikII = false;
                    correctChose = true;
                    selectedBoats.Add(8);
                }
                //TĚŽKÝ KŘIŽNÍK...........
                else if (type == 9 && tezkyKriznik) {
                    ship.Add(new Field { X = 1, Y = 2, Type = 1 });
                    ship.Add(new Field { X = 2, Y = 1, Type = 1 });
                    ship.Add(new Field { X = 2, Y = 2, Type = 1 });
                    ship.Add(new Field { X = 2, Y = 3, Type = 1 });
                    ship.Add(new Field { X = 3, Y = 2, Type = 1 });
                    tezkyKriznik = false;
                    correctChose = true;
                    selectedBoats.Add(9);
                }
                //KATAMARAN.............
                else if (type == 10 && katamaran) {
                    ship.Add(new Field { X = 1, Y = 1, Type = 1 });
                    ship.Add(new Field { X = 1, Y = 2, Type = 1 });
                    ship.Add(new Field { X = 1, Y = 3, Type = 1 });
                    ship.Add(new Field { X = 2, Y = 2, Type = 1 });
                    ship.Add(new Field { X = 3, Y = 1, Type = 1 });
                    ship.Add(new Field { X = 3, Y = 2, Type = 1 });
                    ship.Add(new Field { X = 3, Y = 3, Type = 1 });
                    katamaran = false;
                    correctChose = true;
                    selectedBoats.Add(10);
                }
                //LEHKA BITEVNÍ LOĎ.........
                else if (type == 11 && lehkaBitevniLod) {
                    ship.Add(new Field { X = 1, Y = 1, Type = 1 });
                    ship.Add(new Field { X = 1, Y = 2, Type = 1 });
                    ship.Add(new Field { X = 2, Y = 2, Type = 1 });
                    lehkaBitevniLod = false;
                    correctChose = true;
                    selectedBoats.Add(11);
                }
                //LETADLOVA LOĎ TYP 2..............
                else if (type == 12 && letadlovaLodII) {
                    for (int i = 0; i < 2; i++) {
                        ship.Add(new Field { X = 4 + i, Y = 1, Type = 1 });
                    }
                    for (int i = 0; i < 5; i++) {
                        ship.Add(new Field { X = 1 + i, Y = 2, Type = 1 });
                    }
                    letadlovaLodII = false;
                    correctChose = true;
                    selectedBoats.Add(12);
                }
                //PARNIK......
                else if (type == 13 && parnik) {
                    ship.Add(new Field { X = 2, Y = 1, Type = 1 });
                    ship.Add(new Field { X = 4, Y = 1, Type = 1 });
                    for (int i = 0; i < 5; i++) {
                        ship.Add(new Field { X = 1 + i, Y = 2, Type = 1 });
                    }
                    parnik = false;
                    correctChose = true;
                    selectedBoats.Add(13);
                }
                else {
                    Console.WriteLine("Lod je jiz zabrana nebo jste spatne zadal typ lodi");
                    correctChose = false;
                    shipCreated = false;
                    chose = true;
                    boatID++;
                }
                shipCreated = true;
            }

            if (shipCreated) {
                ships.Add(new Ships { BoatFields = ship });
                boatID++;
            }
        }

        //ULOŽENÍ LODÍ NA POLI..........
        public void placeShip() {
            List<Field> ship = ships[ships.Count - 1].BoatFields;

            bool placeControl = true;

            foreach (Field createdField in createdFields) {
                foreach (Field shipField in ship) {
                    if (shipField.X == createdField.X && shipField.Y == createdField.Y && shipField.Type == createdField.Type || shipField.X - 1 == createdField.X && shipField.Y == createdField.Y && shipField.Type == createdField.Type || shipField.X + 1 == createdField.X && shipField.Y == createdField.Y && shipField.Type == createdField.Type || shipField.X == createdField.X && shipField.Y + 1 == createdField.Y && shipField.Type == createdField.Type || shipField.X == createdField.X && shipField.Y - 1 == createdField.Y && shipField.Type == createdField.Type) {
                        placeControl = false;
                    }
                }
            }
            if (placeControl) {
                foreach (Field shipField in ship) {
                    createdFields.Add(new Field { X = shipField.X, Y = shipField.Y, Type = 1 });
                }
                CreateShip();
                Console.Clear();
            }
        }

        //Vykresleni Mapy
        public void GeneratePole() {
            List<Field> generatedFields = createMap();
            bool otherField = false;

            foreach (Field generatedField in generatedFields) {
                bool boatField = false;
                List<Field> ship = ships[ships.Count - 1].BoatFields;
                foreach (Field shipField in ship) {
                    if (generatedField.X == shipField.X && generatedField.Y == shipField.Y) {
                        if (shipField.Type == 1) {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("O");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(" ");
                            boatField = true;
                            otherField = true;
                        }
                    }
                }
                foreach (Field createdField in createdFields) {
                    if (generatedField.X == createdField.X && generatedField.Y == createdField.Y && boatField == false) {
                        if (createdField.Type == 1) {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("O");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(" ");
                            otherField = true;
                        }
                        if (createdField.Type == 3) {
                            Console.Write("X");
                            Console.Write(" ");
                            otherField = true;
                        }
                    }
                }
                //Kontrola vypsani znaku
                if (!otherField) {
                    Console.Write("L");
                    Console.Write(" ");
                }
                otherField = false;
                //Kontrola radku
                if (generatedField.X == SizeX) {
                    Console.WriteLine();
                }
            }
        }

        //Vykresleni Mapy (Shooting)
        public void GeneratePoleShoot() {
            List<Field> generatedFields = createMap();
            bool otherField = false;
            bool scopeField = false;

            foreach (Field generatedField in generatedFields) {

                if (generatedField.X == scope.X && generatedField.Y == scope.Y) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("×");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" ");
                    otherField = true;
                    scopeField = true;
                }

                foreach (Field shotField in shotFields) {
                    if (generatedField.X == shotField.X && generatedField.Y == shotField.Y && !scopeField) {
                        if (shotField.Type == 3) {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("X");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(" ");
                            otherField = true;
                        }
                        if (shotField.Type == 4) {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("O");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(" ");
                            otherField = true;
                        }
                    }
                }
                //Kontrola vypsani znaku
                if (!otherField) {
                    Console.Write("L");
                    Console.Write(" ");
                }
                otherField = false;
                scopeField = false;
                //Kontrola radku
                if (generatedField.X == SizeX) {
                    Console.WriteLine();
                }
            }
        }

        //Pohybovani lodi (sipky)
        public void MoveBoat() {
            bool moveBoat = true;

            List<Field> shipFields = ships[ships.Count - 1].BoatFields;

            while (moveBoat) {
                bool dirControl = true;
                var key = Console.ReadKey();

                if (key.Key == ConsoleKey.LeftArrow) {
                    foreach (Field shipField in shipFields) {
                        if (shipField.X == 1) {
                            dirControl = false;
                        }
                    }
                    if (dirControl) {
                        foreach (Field shipField in shipFields) {
                            shipField.X--;
                        }
                    }
                }
                if (key.Key == ConsoleKey.UpArrow) {
                    foreach (Field shipField in shipFields) {
                        if (shipField.Y == 1) {
                            dirControl = false;
                        }
                    }
                    if (dirControl) {
                        foreach (Field shipField in shipFields) {
                            shipField.Y--;
                        }
                    }
                }
                if (key.Key == ConsoleKey.DownArrow) {
                    foreach (Field shipField in shipFields) {
                        if (shipField.Y == SizeY) {
                            dirControl = false;
                        }
                    }
                    if (dirControl) {
                        foreach (Field shipField in shipFields) {
                            shipField.Y++;
                        }
                    }
                }
                if (key.Key == ConsoleKey.RightArrow) {
                    foreach (Field shipField in shipFields) {
                        if (shipField.X == SizeX) {
                            dirControl = false;
                        }
                    }
                    if (dirControl) {
                        foreach (Field shipField in shipFields) {
                            shipField.X++;
                        }
                    }
                }
                if (key.Key == ConsoleKey.Enter) {
                    moveBoat = false;
                }
                Console.Clear();
                Console.WriteLine("Posouvejte lod pomoci sipek a potvrdte klavesou 'Enter'");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("1 2 3 4 5 6 7 8 9 10");
                Console.ForegroundColor = ConsoleColor.White;
                GeneratePole();
            }
            MoveShip = true;
            placeShip();
        }

        public void AllCreatedFields() {
            foreach (Field createdField in createdFields) {
                Console.WriteLine("{{X: {0}, Y: {1}, Type: {2}}} ", createdField.X, createdField.Y, createdField.Type);
            }
        }

        public void AllShotFields() {
            foreach (Field shotField in shotFields) {
                Console.WriteLine("{{X: {0}, Y: {1}, Type: {2}}} ", shotField.X, shotField.Y, shotField.Type);
            }
        }

        public bool IsShipSelection() {
            if (selectedBoats.Count() == 3) {
                return false;
            }
            else {
                return true;
            }
        }


        //POLE PLAYER1.......
        /*public void Player1Sea(int xs, int ys, int xe, int ye, int xt, int yt)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(" 0 1 2 3 4 5 6 7 8 9");
        Console.ForegroundColor = ConsoleColor.White;
        for (int x = 0; x < plocha.GetLength(0); x++)
        {

            for (int y = 0; y < plocha.GetLength(1); y++)
            {

                plocha[y, x] = state;
                plocha[ys, xs] = mod;
                plocha[xe, ye] = mod;
                plocha[xt, yt] = mod;
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
    }*/





        //Strileni
        public void Shoot() {
            bool shoot = true;
            bool hit = false;
            bool hited = false;
            Hit = false;

            int type = 3;

            List<Field> shipFields = new List<Field>();

            foreach (Ships ship in ships) {
                foreach (Field shipField in ship.BoatFields) {
                    shipFields.Add(shipField);
                }
            }

            //POHYB PRI STRILENI.........
            while (shoot) {
                bool dirControl = true;
                var key = Console.ReadKey();

                if (key.Key == ConsoleKey.LeftArrow) {
                    if (scope.X == 1) {
                        dirControl = false;
                    }

                    if (dirControl) {
                        scope.X--;
                    }
                }

                if (key.Key == ConsoleKey.UpArrow) {
                    if (scope.Y == 1) {
                        dirControl = false;
                    }

                    if (dirControl) {
                        scope.Y--;
                    }
                }

                if (key.Key == ConsoleKey.DownArrow) {
                    if (scope.Y == SizeY) {
                        dirControl = false;
                    }

                    if (dirControl) {
                        scope.Y++;
                    }
                }

                if (key.Key == ConsoleKey.RightArrow) {
                    if (scope.X == SizeX) {
                        dirControl = false;
                    }

                    if (dirControl) {
                        scope.X++;
                    }
                }

                if (key.Key == ConsoleKey.Enter) {
                    shoot = false;
                    foreach (Field shipField in shipFields) {
                        if (shipField.X == scope.X && shipField.Y == scope.Y) {
                            hit = true;
                        }
                    }
                }

                Console.Clear();
                Console.WriteLine("Vyberte pole pomoci sipek a potvrdte klavesou 'Enter'");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("1 2 3 4 5 6 7 8 9 10");
                Console.ForegroundColor = ConsoleColor.White;
                GeneratePoleShoot();
            }
            if (hit) {
                type = 4;
                Hit = true;

                Field scopeField = new Field { X = scope.X, Y = scope.Y, Type = type };

                foreach (Field shotField in shotFields) {
                    if (scopeField.X == shotField.X && scopeField.Y == shotField.Y) {
                        hited = true;
                    }
                    else {
                        hited = false;
                    }
                }
            }
            if (!hited) {
                shotFields.Add(new Field {
                    X = scope.X,
                    Y = scope.Y,
                    Type = type
                });
            }
        }

        //Kontrola zdali hrac nevyhral
        public bool IsWinner() {
            List<Field> shipFields = new List<Field>();

            int shots = 0;

            foreach (Ships ship in ships) {
                foreach (Field shipField in ship.BoatFields) {
                    shipFields.Add(shipField);
                }
            }

            foreach (Field shipField in shotFields) {
                foreach (Field shotField in shotFields) {
                    if (shipField.X == shotField.X && shipField.Y == shotField.Y && shotField.Type == 4) {
                        shots++;
                    }
                }
            }

            if (shipFields.Count == shots) {
                return true;
            }
            else {
                return false;
            }
        }
    }
}
