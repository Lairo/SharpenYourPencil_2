using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenYourPencil_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Pizzazz foxtrot = new Pizzazz() { Zippo = 2 };
            foxtrot.Bamboo(foxtrot.Zippo);
            Pizzazz november = new Pizzazz() { Zippo = 3 };
            Abracadabra tango = new Abracadabra() { Vavavoom = 4 };
            while (tango.Lala(november.Zippo))
            {
                november.Zippo *= -1;
                november.Bamboo(tango.Vavavoom);
                foxtrot.Bamboo(november.Zippo);
                tango.Vavavoom -= foxtrot.Zippo;
            }
            Console.WriteLine("november.Zippo = " + november.Zippo);
            Console.WriteLine("foxtrot.Zippo = " + foxtrot.Zippo);
            Console.WriteLine("tango.Vavavoom = " + tango.Vavavoom);
        }
    }
}
/* foxtrot.Zippo = 2
 * foxtrot.Bamboo(2)
 * november.Zippo = 3
 * tango.Vavavoom = 4
 * tango.Lala(3)
 * 
 * november.Zippo = - 3
 * november.Bamboo(4) // Zippo = 6
 * foxtrot.Bamboo(3)
 * tango.Vavavoom = -2
 *
 *
 *
 * 
 */
