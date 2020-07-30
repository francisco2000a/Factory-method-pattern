using System;
using System.Collections.Generic;
using System.Text;

namespace metodofabrica
{
    class auto:ivehiculo
    {
        public void Encender()
        {
            Console.WriteLine("introduce la llave y girela");
        }
        public void Acelerar()
        {
            Console.WriteLine("oprime el pedal para acelerar");
        }
        public void Frenar()
        {
            Console.WriteLine("presione el pedel de freno");
        }
        public void Girar()
        {
            Console.WriteLine("toma el pedal y girelo");
        }




    }
}
