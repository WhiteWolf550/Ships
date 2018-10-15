using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle {
    class Program {
        static void Main(string[] args) {
            int height = 15;
            int width = 15;
            int i, j, spc, rows, k;
            //TROJUHELNIK...
            Console.Write("Input number of rows : ");
            rows = Convert.ToInt32(Console.ReadLine());
            spc = rows + 4 - 1;
            for (i = 1; i <= rows; i++) {
                for (k = spc; k >= 1; k--) {
                    Console.Write(" ");
                }

                for (j = 1; j <= i; j++)
                    Console.Write("* ");
                Console.Write("\n");
                spc--;
            }
            //CTVEREC...
            for (int z = 0; z < height; z++) {
                Console.WriteLine("");
                for (int c = 0; c < width; c++) {
                    if (z > 0 && c > 0) {
                        if (z < height - 1 && c < width - 1) {
                            Console.Write(" ");
                            Console.Write(" ");

                        }
                        else
                            Console.Write("* ");
                            
                    }
                    else
                        Console.Write("* ");
                }
            

            }
        }
        }
    }

