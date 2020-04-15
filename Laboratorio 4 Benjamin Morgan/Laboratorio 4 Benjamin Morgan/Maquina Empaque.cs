using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_4_Benjamin_Morgan
{
    class Maquina_Empaque: Funciones_Maquinas
    {
        public Maquina_Empaque()
        {

        }

        int x;
        public override void memoria()
        {
            if (x == 15)
            {
                x = 0;
                Console.WriteLine("Maquina Empaque, se lleno la memoria de la maquina");
            }
            else
            {
                x += 1;



            }

        }



    }
}
