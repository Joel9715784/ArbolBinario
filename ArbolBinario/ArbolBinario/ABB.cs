using System;
using BinarioArbol;
namespace ARBB

{
    public class ARBB
    {
        public Nodo vector;

        public ARBB() 
        {
            raiz = null;
        }
   
        public void insertar(int valor)
        {
            if (vector == null)
            {
                vector = new Nodo();
                vector.valor = valor;
            }
            else
            {
                Nodo nuevo = new Nodo();
                nuevo.valor = valor;
                nuevo.hijo1 = null;
                nuevo.hijo2 = null;


                
                Nodo anterior = null, recorrer;
                while (recorrer != null)
                {
                    anterior = recorrer;
                    if (valor < recorrer.valor)
                    {
                        recorrer = recorrer.hijo2;
                    }
                    else
                    {
                        recorrer = recorrer.hijo1;

                    }
                }
                if (valor < anterior.valor)
                {
                    anterior.hijo2 = nuevo;
                }
                else
                {
                    anterior.hijo1 = nuevo;
                }
            }
        }
      
        public void PreOrden(Nodo vector)
        {
            Console.WriteLine(vector.valor);
            
            if (vector.hijo1 != null)
            {
                PreOrden(vector.hijo1);
            }
            if (vector.hijo2 !=null)
            {
                PreOrden(vector.hijo2);
            }
        }
       
        public void EnOrden(Nodo vector)
        {
            if (vector.hijo1 != null)
            
                EnOrden(vector.hijo1);
                Console.WriteLine(vector.valor);
            
            if (vector.hijo2 != null)
            
                EnOrden(vector.hijo2);
              
            
        }
        
        public void PostOrden(Nodo vector)
        {
            if (vector.hijo1 != null)
            
                PostOrden(vector.hijo1);
            
            if (vector.hijo2 != null)
            
                PostOrden(vector.hijo2);
            
            Console.WriteLine(vector.valor);
        }
    }
}
