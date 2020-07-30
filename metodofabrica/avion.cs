using System;
using System.Collections.Generic;
using System.Text;

namespace metodofabrica
{
    class avion:ivehiculo
    {
        public void Encender()
        {
            Console.WriteLine("sigue todo el procedimiento");
        }
        public void Acelerar()
        {
            Console.WriteLine("empuje el acelerador");
        }
        public void Frenar()
        {
            Console.WriteLine("jala el acelerador");
        }
        public void Girar()
        {
            Console.WriteLine("mueve el timon de la cola");
        }




    }
}
