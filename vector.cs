using System;
using System.Collections.Generic;
using System.Text;

namespace VECTORES
{
    class vector
    {
     
      //  public int[] max { get; set; }

    /*    public vector(int[] numeros, int[] max)
        {
            this.numeros = numeros;
            this.max = max;
        }*/
      /*  public vector()
        {

        }*/

     int [] numeros = new int[5];
     int i = 0;
        public void insertarVector()
        {    
            Console.WriteLine("Escribe los Numeros:");
            if (i <numeros.Length)
            {
              //  try
              //  {       
                    numeros[i] = Convert.ToInt32(Console.ReadLine());
                    i++;
               //}
               // catch(System.FormatException)
               // {    Console.WriteLine("formato no valida"); }
            }
            else
            {
                Console.WriteLine("no hay espacio");
            }
            
          }

        public void mostrarVector()
        {

                for (int i = 0; i < numeros.Length; i++)
                {
                    Console.Write(" | " + numeros[i]);    
                }
              
        }

        public void eliminarVector()
        {
            Console.WriteLine("Escriba el Numero que quiere Eliminar:");
            int numeroeliminar = Convert.ToInt32(Console.ReadLine());

            if(numeroeliminar==-1)
            {
                Console.WriteLine("elemento no encontrado");
            }
            for (int i = 0; i < numeros.Length; i++)
            {              
                if (numeros[i] == numeroeliminar)
                {
                    
                    numeros[i] = 0;
                    
                }
                
            }
            Console.WriteLine("Numero  encontrado: " + numeroeliminar);
            Console.WriteLine("Numero Eliminado");

        }

        public void modificarVector()
        {
            Console.WriteLine("Escriba el Numero que quiere Modificar:");
            int numeromodificar = Convert.ToInt32(Console.ReadLine());
 
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == numeromodificar)
                {
                    Console.WriteLine("Numero  encontrado: ");
                    Console.WriteLine("Escriba por el Numero que lo quiere reemplazar: ");
                  int nuevonumero = Convert.ToInt32(Console.ReadLine());
                    numeros[i] = nuevonumero;

                }

            }

        }

        public void buscarVector()
        {
            Console.WriteLine("Escriba el Numero que quiere Buscar:");
            int numerobuscar = Convert.ToInt32(Console.ReadLine());


            int veces = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == numerobuscar)
                {

                    veces++;
                }
            }
            if(veces>=1)
            { Console.WriteLine("Numero: " + numerobuscar + " encontrado ");
                Console.WriteLine("veces:"+veces+" en la posicion : "+i);              
             }
              else
               {
                    Console.WriteLine("no esta");
                }
        

        }

     
        public void borrarVector()
        {
            numeros = new int[5];
             i = 0;
        }

        public void creditosAlumnos()
        {
            
            Console.WriteLine("P");
            Console.WriteLine("S");
        }
    }
}
