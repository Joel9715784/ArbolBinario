using Adt;
using System;

namespace AdtApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arbol Binario");

            var raiz = new Nodo();
            raiz.Nombre = "1";

            var nodoDos = new Nodo();
            nodoDos.Nombre = "1.1";

            var nodoTres = new Nodo();
            nodoTres.Nombre = "1.2";

            raiz.Izquierdo = nodoDos;
            raiz.Derecho = nodoTres;

            //metodo imprimir recursivo

            AdministradorNodo an =  new AdministradorNodo();
            an.Imprimir(raiz);



        }
    }
}
