using System;
using System.Collections.Generic;
using System.Text;

namespace metodofabrica
{
    class creador
    {
        //aqui implementamos el metodo
        public static ivehiculo MetodoFabrica(int pDinero)

        {
            ivehiculo temp = null;
            // selecionamos el tipo de instancia segun nuestras reglas
            if (pDinero > 10000)
                temp = new avion();
            else if (pDinero > 1500)
                temp = new auto();
            else
                temp = new Bicicleta();

            return temp;

        }




    }
}
