using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArregloNombres
{
    public class NombresGenerador
    {
        public string[] firstLetterName = { "breezy", "wild", "roaming", "sweet", "lush", "happy", "free", "spirited", "young" };
        public string[] colorShirt = { "mountain", "river", "sun", "oak", "vine", "bud", "wind", "stone", "tide" };
        public string[] firstLetterLastName = { "gypsy", "dancer", "yogi", "warrior", "soul", "hippie", "wanderer", "spirit", "treehugger" };

        public void generar(int slot1, int slot2, int slot3)
        {
            Console.WriteLine(" ");
            Console.WriteLine("First Letter Name");
            for (int i = 0; i < firstLetterName.Length; i++)
            {
                Console.WriteLine(i + ".-" + firstLetterName[i]);
            }

            Console.WriteLine(" ");
            Console.WriteLine("Color Shirt");
            for (int i = 0; i < colorShirt.Length; i++)
            {
                Console.WriteLine(i + ".-" + colorShirt[i]);
            }

            Console.WriteLine(" ");
            Console.WriteLine("First Letter of your Last Name");
            for (int i = 0; i < firstLetterLastName.Length; i++)
            {
                Console.WriteLine(i + ".-" + firstLetterLastName[i]);
            }

            Console.WriteLine(" ");
            Console.WriteLine(firstLetterName[slot1] + " " + colorShirt[slot1] + " " + firstLetterLastName[slot3]);
            
        }
    }

    
}
