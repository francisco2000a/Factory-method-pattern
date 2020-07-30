using System;
using System.Collections.Generic;
using System.Text;

namespace metodofabrica
{
    class Bicicleta:ivehiculo
    {
        public void Encender()
        {
            Console.WriteLine("la bicicleta no necesita encender");
                  }
        public void Acelerar() 
        {
            Console.WriteLine("pedalea fuerte para acelerar");
        }
       public void Frenar() 
        {
            Console.WriteLine("presiona el freno trasero primero");
        }
        public void Girar()
        {
            Console.WriteLine("usa el manubrio");
        }




    }
}
