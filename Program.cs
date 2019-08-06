using System;

namespace PF_Control_de_Rutas
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona();
            Persona persona2 = new Persona();
            Persona persona3 = new Persona();

            persona3.IngresarPersona();
            persona3.ImprimirPersona();
            persona3.ModificarLicencia();
            persona3.ImprimirPersona();
            Console.ReadLine();

        }
    }
}
