using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ships {
    class Ships {
        public bool IsDestroyed = false;
        //public int[,] Shiploc = new int[10, 10];

        public void ShipAttack() {
            Random rn = new Random();
            int hitx = rn.Next(1, 9);
            int hity = rn.Next(1, 9);


        }
    }
}
