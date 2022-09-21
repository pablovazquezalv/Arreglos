using System;

namespace VECTORES
{
    class Program
    {
        static void Main(string[] args)
        {
            menu mimenu = new menu();
            char opcion;
            vector mivector = new vector();
        
            do
            {           
                opcion = mimenu.menuOpciones();
                switch (opcion)
                {
                    case 'A':
                        //INSERTAR
                        mivector.insertarVector();
                        break;
                    case 'B':
                        //BORRAR TOTALMENTE
                        mivector.borrarVector();
                        break;

                    case 'C':
                        //MOSTRAR
                        mivector.mostrarVector();
                        break;
                    case 'D':
                        //BUSCAR
                        mivector.buscarVector();
                        break;
                    case 'E':
                        //INSERTAR
                        mivector.insertarVector();
                        break;
                    case 'F':
                        //ELIMINAR
                        mivector.eliminarVector();
                        break;
                    case 'G':
                        //MODIFICAR
                        mivector.modificarVector();
                        break;
                    case 'H':
                        //CREDITOS
                        mivector.creditosAlumnos();
                        break;
                    default:
                        break;

                }
            } while (opcion != 'J');
                
            


        }
    }
}
