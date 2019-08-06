using System;
using System.Collections.Generic;
using System.Text;

namespace PF_Control_de_Rutas
{
    class Persona
    {
        #region Atributos
        #endregion

        #region Propiedades
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Documento { get; set; }
        public int Licencia { get; set; }
        #endregion

        #region Constructores
        public Persona (string nombre, string apellido, int documento, int licencia)
        {
            Nombre = nombre;
            Apellido = apellido;
            Documento = documento;
            Licencia = licencia;

        }
        public Persona()
        {

        }
        #endregion
        #region Metodos
        public void IngresarPersona()
        {
            Console.WriteLine("Ingrese el nombre de la persona: ");
            Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido de la persona");
            Apellido = Console.ReadLine();
            Console.WriteLine("Ingrese identificacion de la persona");
            Documento = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese numero de licencia");
            Licencia = int.Parse(Console.ReadLine());
        }
        public void ImprimirPersona()
        {
            Console.WriteLine($"El nombre de la persona es :{Nombre} {Apellido}");
            Console.WriteLine($"El numero de documento de {Nombre} {Apellido} es:{Documento}");
            Console.WriteLine($" La licencia de {Nombre} {Apellido} es: {Licencia}");
        }
        public void ModificarLicencia()
        {
            Console.WriteLine("Quieres modificar la licencia? \n 1 si \n 0 no");
            int rta = int.Parse(Console.ReadLine());
            if (rta==1)
            {
                Console.WriteLine("ingrese el numero de la licencia");
                Licencia = int.Parse(Console.ReadLine());
            }
            else
            {

            }
        }
        #endregion

    }



}
