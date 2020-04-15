using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_4_Benjamin_Morgan
{
    abstract class Funciones_Maquinas
    {

        public Funciones_Maquinas()
        {

        }
        public void on()
        {
            Console.WriteLine(" Se a encendido la maquina" );

        }


        public virtual void memoria()
        {

        }



        public void off()
        {
            Console.WriteLine(" Se a apagado la maquina");

        }

    }
}
