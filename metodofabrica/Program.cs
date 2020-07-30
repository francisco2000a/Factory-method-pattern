using System;

namespace metodofabrica
{
    class Program
    {
        static void Main(string[] args)
        {
             string dato;
            int Cdinero;
            ivehiculo vehiculo;

            Console.WriteLine("cuanto dinero tiene para su vehiculo");
            dato = Console.ReadLine();
            Cdinero = Convert.ToInt32(dato);


            //obtenemos el metodo de fabrica
            vehiculo = creador.MetodoFabrica(Cdinero);

            vehiculo.Encender();
            vehiculo. Acelerar();
            vehiculo. Frenar();
            vehiculo.Girar();



        }
    }
}
