using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GridFilter
{
    public class Item
    {
        public Item(int numero, string testo)
        {
            Numero = numero;
            Testo = testo;
        }

        public int Numero { get; set; }
        public string Testo{ get; set; }
    }
}
