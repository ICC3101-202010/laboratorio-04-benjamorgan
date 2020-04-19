using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_4_Benjamin_Morgan
{
    class Maquina_Recepcion : Funciones_Maquinas, IFunciones_Cambiantes
    {
        public Maquina_Recepcion()
        {

        }


        int x;
        public void memoria()
        {
            if (x == 12)
            {
                callworker();
            }
            if (x > 12)
                Console.WriteLine("Maquina descompuesta, no se tomaron medidas a tiempo");
            else
                x += 1;
        }
        public void callworker()
        {
            Console.WriteLine("Memoria insuficiente en Maquina Recepcion, Accion de trabajador es necesaria");
            Console.WriteLine("El trabajador va a venir?  (y/n)");
            string resp = Console.ReadLine();

            if (resp == "y")
            {
                x = 0;
                Console.WriteLine("maquina reiniciada exitosamente");
            }
            else
                x = 20;


        }
    }
}
