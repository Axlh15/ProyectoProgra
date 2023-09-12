using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArregloNombres
{
    public class NombresGenerador
    {
        public string[] natures = { "breezy", "wild", "roaming", "sweet", "lush", "happy", "free", "spirited", "young" };
        public string[] objects = { "mountain", "river", "sun", "oak", "vine", "bud", "wind", "stone", "tide" };
        public string[] roles = { "gypsy", "dancer", "yogi", "warrior", "soul", "hippie", "wanderer", "spirit", "treehugger" };

        public void generar(int slot1, int slot2, int slot3)
        {
            Console.WriteLine(" ");
            //Console.WriteLine("First Letter Name");
            //for (int i = 0; i < natures.Length; i++)
            {
                //Console.WriteLine(i + ".-" + natures[i]);
            }

            //Console.WriteLine(" ");
            //Console.WriteLine("Color Shirt");
            //for (int i = 0; i < objects.Length; i++)
            {
                //Console.WriteLine(i + ".-" + objects[i]);
            }

            //Console.WriteLine(" ");
            //Console.WriteLine("First Letter of your Last Name");
            //for (int i = 0; i < roles.Length; i++)
            {
                //Console.WriteLine(i + ".-" + roles[i]);
            }

            //Console.WriteLine(" ");
            Console.WriteLine(natures[slot1] + " " + objects[slot1] + " " + roles[slot3]);
            
        }
    }

    
}
