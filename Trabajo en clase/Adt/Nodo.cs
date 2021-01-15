using System;
using System.Collections.Generic;

namespace Adt
{
    public class Nodo
    {
        //creacion de un arbol
        public string Nombre { get; set; }
        //public List<Nodo> Hijos { get; set; }

        public Nodo Izquierdo { get; set; }
        public Nodo Derecho { get; set; }
    }
}
