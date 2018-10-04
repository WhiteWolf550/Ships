using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Witcher
{
    class Program
    {
        static void Main(string[] args)
        {
            SoundPlayer player = new SoundPlayer(@"E:\C#\Witcher\Believe.wav");
            SoundPlayer geralt = new SoundPlayer(@"E:\C#\Witcher\geralt.wav");
            player.Play();
            Console.ReadLine();
            Console.WriteLine("Geralt");
            geralt.Play();
            Console.ReadLine();
        }
    }
}
