using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorAlumnos
{
    class Program
    {
        //mostrar alumnos
        //añadir alumnos 
        static FactoriaAlumnos fa = null;

        static void Main(string[] args)
        {
            int opcion = 0;
            fa = new FactoriaAlumnos();
            opcion = MostrarMenu();
            EjecutarOpciones(opcion);
            Console.ReadKey();
        }
        private static void EjecutarOpciones(int opcion)
        {

            switch (opcion)
            {
                case 1:// Mostrar Alumnos
                    MostrarAlumnos(); 
                    break;
                case 2: //Añadir Alumnos
                    //AñadirAlumno();
                    break;
            }
        }

        public static void AddAlumno()
        {

            Alumno al = new Alumno();

            fa.AddAlumno(al);
        }



        }


        private static int MostrarMenu()
        {
            int opcion = 0;

            Console.WriteLine("1.- Mostrar Alumnos");
            Console.WriteLine("2.- Añadir Alumno");

            opcion = Int32.Parse(Console.ReadLine());

            return opcion;
        }
    }
}