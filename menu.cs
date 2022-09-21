using System;
using System.Collections.Generic;
using System.Text;

namespace VECTORES
{
    class menu
    {
            public char opcion { get; set; }

        public menu(char opcion)
        {
            this.opcion = opcion;
        }
        public menu()
        {

        }
        public char menuOpciones()
        {
            char opcion;
            Console.WriteLine();
            Console.WriteLine("Seleccione la opcion que desea hacer:");
            Console.WriteLine("(A) INSERTAR");
            Console.WriteLine("(B) BORRAR ARREGLO");
            Console.WriteLine("(C) MOSTRAR");
            Console.WriteLine("(D) BUSCAR");
            Console.WriteLine("(E) INSERTAR");
            Console.WriteLine("(F) ELIMINAR");
            Console.WriteLine("(G) MODIFICAR");
            Console.WriteLine("(H) CREDITOS");
            Console.WriteLine("(J) Salir");
            opcion = Convert.ToChar(Console.ReadLine());
                return opcion;

        }


    }
}
