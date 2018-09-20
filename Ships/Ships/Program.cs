using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ships {
    class Program {
        static void Main(string[] args) {

            Pole pole = new Pole();
            for (int x = 0; x < pole.plocha.GetLength(0); x++) {

                for (int y = 0; y < pole.plocha.GetLength(1); y++) {
                    pole.plocha[x, y] = "L";
                    Console.Write(" " + pole.plocha[x, y]);
                }
                Console.WriteLine();
            } 
        }
    }
}
