using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_4_Benjamin_Morgan
{
    class Program
    {
        static void Main(string[] args)
        {
            Maquina_Recepcion maquina1 = new Maquina_Recepcion();
            Maquina_Almacenamiento maquina2 = new Maquina_Almacenamiento();
            Maquina_Ensamblaje maquina3 = new Maquina_Ensamblaje();
            Maquina_Empaque maquina4 = new Maquina_Empaque();
            Maquina_Verificacion maquina5 = new Maquina_Verificacion();

            Console.WriteLine("maquina recepcion ");
            maquina1.on();
            Console.WriteLine("maquina Almacenamiento ");
            maquina2.on();
            Console.WriteLine("maquina Ensamblaje ");
            maquina3.on();
            Console.WriteLine("maquina Empaque ");
            maquina4.on();
            Console.WriteLine("maquina Verificacion ");
            maquina5.on();
            System.Threading.Thread.Sleep(2000);
            int tiempo =  0;
            //para efecto de prueba uso un numero bajo, para mas iteraciones aumentar el numero dentro del siguiente while
            while (tiempo <= 15)
            {
                maquina1.memoria();              
                maquina2.memoria();
                maquina3.memoria();
                maquina4.memoria();
                maquina5.memoria();
                Console.WriteLine("");
                //System.Threading.Thread.Sleep(1000);
                tiempo += 1;
            }

            Console.WriteLine("");

            Console.WriteLine("maquina recepcion ");
            maquina1.off();
            Console.WriteLine("maquina Almacenamiento ");
            maquina2.off();
            Console.WriteLine("maquina Ensamblaje ");
            maquina3.off();
            Console.WriteLine("maquina Empaque ");
            maquina4.off();
            Console.WriteLine("maquina Verificacion ");
            maquina5.off();

            Console.ReadLine();
        }
    }
}
