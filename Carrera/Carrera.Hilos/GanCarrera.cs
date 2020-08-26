using System.Threading;
using System;
using System.Diagnostics;

namespace Carrera.Hilos
{
    class GanCarrera
    {
        static void Main()
        {
            Console.WriteLine("  ________________________________ ");
            Console.WriteLine(" ||||||||||||||||||||||||||||||||||");
            Console.WriteLine(" __________________________________");
            Console.WriteLine("         INICIO CARRERA            ");
            Console.WriteLine(" __________________________________");
            Console.WriteLine(" ||||||||||||||||||||||||||||||||||");
            Console.WriteLine("  ________________________________ ");
            Console.WriteLine("");

            //Thread carril = new Thread(Carril);

            Thread carril1 = new Thread(Carril1);
            Thread carril2 = new Thread(Carril2);
            Thread carril3 = new Thread(Carril3);
            Thread carril4 = new Thread(Carril4);
            Thread carril5 = new Thread(Carril5);
            Thread carril6 = new Thread(Carril6);
            Thread carril7 = new Thread(Carril7);
            Thread carril8 = new Thread(Carril8);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            //var corredor1 = new Corredor { CarrilPartida = 1, Simbolo= 'S' };
            //carril1.Start(corredor1);
            carril1.Start();

            stopwatch.Stop();
            var tiempo_carril1 = stopwatch.ElapsedTicks;

            Stopwatch stopwatch1 = new Stopwatch();
            stopwatch1.Start();

            carril2.Start();

            stopwatch1.Stop();
            var tiempo_carril2 = stopwatch1.ElapsedTicks;

            Stopwatch stopwatch2 = new Stopwatch();
            stopwatch.Start();

            carril3.Start();

            stopwatch.Stop();
            var tiempo_carril3 = stopwatch.ElapsedTicks;

            Stopwatch stopwatch3 = new Stopwatch();
            stopwatch.Start();

            carril4.Start();

            stopwatch.Stop();
            var tiempo_carril4 = stopwatch.ElapsedTicks;

            Stopwatch stopwatch4 = new Stopwatch();
            stopwatch.Start();

            carril5.Start();

            stopwatch.Stop();
            var tiempo_carril5 = stopwatch.ElapsedTicks;

            Stopwatch stopwatch5 = new Stopwatch();
            stopwatch.Start();

            carril6.Start();

            stopwatch.Stop();
            var tiempo_carril6 = stopwatch.ElapsedTicks;

            Stopwatch stopwatch6 = new Stopwatch();
            stopwatch.Start();

            carril7.Start();

            stopwatch.Stop();
            var tiempo_carril7 = stopwatch.ElapsedTicks;

            Stopwatch stopwatch7 = new Stopwatch();
            stopwatch.Start();

            carril8.Start();

            stopwatch.Stop();
            var tiempo_carril8 = stopwatch.ElapsedTicks;



            Ganador(tiempo_carril1, tiempo_carril2, tiempo_carril3, tiempo_carril4, tiempo_carril5, tiempo_carril6, tiempo_carril7, tiempo_carril8);
        }

        //public static void Carril(object corredor)
        //{
        //    Corredor miCorredor = (Corredor)corredor; 
        //    // aclarar variables
        //    //strat
        //    int nt = 0;
        //    while (nt <= 10)
        //    {
        //        Random rnd = new Random();
        //        int pasos = rnd.Next(1, 3);
        //        Console.WriteLine(" | S |   |   |   |   |   |   |   |");
        //        nt += pasos;
        //        Thread.Sleep(1000);
        //    }
        //    //miCorredor.Duracion = 
        //}
        public static void Carril1()
        {
            // aclarar variables
            int nt = 0;
            while(nt <= 10)
            {
                Random rnd = new Random();
                int pasos = rnd.Next(1, 3);
                Console.WriteLine(" | S |   |   |   |   |   |   |   |");
                nt += pasos;
                Thread.Sleep(1000);
            } 
        }

        public static void Carril2()
        {
            int nt = 0;
            while (nt <= 10)
            {
                Random rnd = new Random();
                int pasos = rnd.Next(1, 3);
                Console.WriteLine(" |   | T |   |   |   |   |   |   |");
                nt += pasos;
                Thread.Sleep(1000);
            } 
        }

        public static void Carril3()
        {
            int nt = 0;
            while (nt <= 10)
            {
                Random rnd = new Random();
                int pasos = rnd.Next(1, 3);
                Console.WriteLine(" |   |   | U |   |   |   |   |   |");
                nt += pasos;
                Thread.Sleep(1000);
            }
        }

        public static void Carril4()
        {
            int nt = 0;
            while (nt <= 10)
            {
                Random rnd = new Random();
                int pasos = rnd.Next(1, 3);
                Console.WriteLine(" |   |   |   | V |   |   |   |   |");
                nt += pasos;
                Thread.Sleep(1000);
            }
        }

        public static void Carril5()
        {
            int nt = 0;
            while (nt <= 10)
            {
                Random rnd = new Random();
                int pasos = rnd.Next(1, 3);
                Console.WriteLine(" |   |   |   |   | W |   |   |   |");
                nt += pasos;
                Thread.Sleep(1000);
            }
        }

        public static void Carril6()
        {
            int nt = 0;
            while (nt <= 10)
            {
                Random rnd = new Random();
                int pasos = rnd.Next(1, 3);
                Console.WriteLine(" |   |   |   |   |   | X |   |   |");
                nt += pasos;
                Thread.Sleep(1000);
            }
        }
        public static void Carril7()
        {
            int nt = 0;
            while (nt <= 10)
            {
                Random rnd = new Random();
                int pasos = rnd.Next(1, 3);
                Console.WriteLine(" |   |   |   |   |   |   | Y |   |");
                nt += pasos;
                Thread.Sleep(1000);
            }
        }

        public static void Carril8()
        {
            int nt = 0;
            while (nt <= 10)
            {
                Random rnd = new Random();
                int pasos = rnd.Next(1, 3);
                Console.WriteLine(" |   |   |   |   |   |   |   | Z |");
                nt += pasos;
                Thread.Sleep(1000);
            }
        }

        public static void Ganador(long tiempoC1, long tiempoC2, long tiempoC3, long tiempoC4, long tiempoC5, long tiempoC6, long tiempoC7, long tiempoC8)
        {
            long menor1 = Math.Min(tiempoC1, tiempoC2);
            long menor2 = Math.Min(menor1, tiempoC3);
            long menor3 = Math.Min(menor2, tiempoC4);
            long menor4 = Math.Min(menor3, tiempoC5);
            long menor5 = Math.Min(menor4, tiempoC6);
            long menor6 = Math.Min(menor5, tiempoC7);
            long ganador = Math.Min(menor6, tiempoC8);
            Thread.Sleep(10000);

            Console.WriteLine(" ________________________________ ");
            Console.WriteLine(" |||||   |||||   |||||   |||||   |");
            Console.WriteLine(" |   |||||   |||||   |||||   |||||");
            Console.WriteLine(" ________________________________ ");
            Console.WriteLine("               META               ");
            Console.WriteLine(" ________________________________");
            Console.WriteLine(" |||||   |||||   |||||   |||||   |");
            Console.WriteLine(" |   |||||   |||||   |||||   |||||");
            Console.WriteLine("");
            Console.WriteLine("Tiempo de llegada de S: {0}", tiempoC1);
            Console.WriteLine("Tiempo de llegada de T: {0}", tiempoC2);
            Console.WriteLine("Tiempo de llegada de U: {0}", tiempoC3);
            Console.WriteLine("Tiempo de llegada de V: {0}", tiempoC4);
            Console.WriteLine("Tiempo de llegada de W: {0}", tiempoC5);
            Console.WriteLine("Tiempo de llegada de X: {0}", tiempoC6);
            Console.WriteLine("Tiempo de llegada de Y: {0}", tiempoC7);
            Console.WriteLine("Tiempo de llegada de Z: {0}", tiempoC8);
            Console.WriteLine("");
            Console.WriteLine("El ganador es: {0}", ganador);
        }
    }
}
