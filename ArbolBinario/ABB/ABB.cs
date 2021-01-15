using System;
using BinarioArbol;

namespace ARBB
{
    public class ARBB
    {
        public Nodo vector;

        
        public ARBB() {
            vector = null;
        }

        public void insertar() {
            if (vector == null)
            {
                vector = new Nodo();
                vector.valor = valor;
            }
            else 
            {
                Nodo nuevo = new Nodo();
                nuevo.valor = valor;
            }
        }
    }
}
