using System;
using System.Threading;

namespace Hilos.ConsolaApp
{
    class EjemploHilos
    {

        public static void ProcedimientoHilo(object id)
        {
            int identificador = (int)id;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Hilo secundario {identificador}: Iteración {i}");
                Thread.Sleep(0);
            }
        }

        public static void Main()
        {
            Console.WriteLine("Hilo principal: Inicia al segundo hilo");
            Thread[] hilos = new Thread[1000];
            for(int i =0; i < 1000; i++)
            {
                hilos[0] = new Thread(ProcedimientoHilo);
                
            }
            //Thread t = new Thread(new ThreadStart(ProcedimientoHilo));
            Console.WriteLine("Cuanto hilo hay?:");
            Console.ReadLine();
            
            for (int i = 0; i < 1000; i++)
            {
                hilos[0].Start(i);

            }


            Thread.Sleep(0);

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Hilo principal: me estoy ejecutando");
                Thread.Sleep(0);
            }
            for (int i = 0; i < 1000; i++)
            {
              hilos[i]?.Join();
            }
                Console.WriteLine("Hilo principal: llamo a la funcion de 'union()', para esperar al hilo secundario");
            Console.WriteLine("Hilo principal: El hilo secundario se ha unido. Prescione cualquier tecla para continuar.");
            Console.ReadLine();
        }
    }
}
