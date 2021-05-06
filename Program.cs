using System;
using System.Threading;

namespace ProjectX
{
    class Program
    {
        public static int MainMenu()
        {
            ConsoleKeyInfo option;
            int contadorMenu = 0;

            Console.SetCursorPosition(40, 12);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("BIENVENIDO, SELECCIONE UN JUEGO");
            Console.SetCursorPosition(40, 13);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("--------------------------------");

            Console.SetCursorPosition(40, 15);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("AHORCADO");

            Console.SetCursorPosition(35, 15);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("--->");
            Console.BackgroundColor = ConsoleColor.Black;

            Console.SetCursorPosition(40, 16);
            Console.Write("ANAGRAMAS");
            Console.BackgroundColor = ConsoleColor.Black;

            Console.SetCursorPosition(40, 17);
            Console.Write("JUEGO MATEMÁTICO");
            Console.BackgroundColor = ConsoleColor.Black;

            Console.SetCursorPosition(40, 18);
            Console.Write("ESQUIVA LAS FLECHAS");
            Console.BackgroundColor = ConsoleColor.Black;

            Console.SetCursorPosition(40, 19);
            Console.Write("SALIR");
            Console.BackgroundColor = ConsoleColor.Black;

            Console.SetCursorPosition(40, 15);

            option = Console.ReadKey(true);

            while (option.Key != ConsoleKey.Enter)
            {
                switch (option.Key)
                {
                    case ConsoleKey.DownArrow:

                        if (contadorMenu < 4)
                            contadorMenu++;

                        if (contadorMenu == 1)
                        {
                            Console.SetCursorPosition(40, 12);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("BIENVENIDO, SELECCIONE UN JUEGO");
                            Console.SetCursorPosition(40, 13);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("--------------------------------");

                            Console.SetCursorPosition(40, 15);
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Write("AHORCADO");

                            Console.SetCursorPosition(35, 15);
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Write("    ");

                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.SetCursorPosition(40, 16);
                            Console.Write("ANAGRAMAS");
                            Console.BackgroundColor = ConsoleColor.Black;

                            Console.SetCursorPosition(35, 16);
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Write("--->");
                            Console.BackgroundColor = ConsoleColor.Black;

                            Console.SetCursorPosition(40, 17);
                            Console.Write("JUEGO MATEMÁTICO");
                            Console.BackgroundColor = ConsoleColor.Black;

                            Console.SetCursorPosition(40, 18);
                            Console.Write("ESQUIVA LAS FLECHAS");
                            Console.BackgroundColor = ConsoleColor.Black;

                            Console.SetCursorPosition(40, 19);
                            Console.Write("SALIR");
                            Console.BackgroundColor = ConsoleColor.Black;

                            Console.SetCursorPosition(40, 16);
                        }
                        else
                        {
                            if (contadorMenu == 2)
                            {
                                Console.SetCursorPosition(40, 12);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("BIENVENIDO, SELECCIONE UN JUEGO");
                                Console.SetCursorPosition(40, 13);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("--------------------------------");

                                Console.SetCursorPosition(40, 15);
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.Write("AHORCADO");

                                Console.SetCursorPosition(40, 16);
                                Console.Write("ANAGRAMAS");
                                Console.BackgroundColor = ConsoleColor.Black;

                                Console.SetCursorPosition(35, 16);
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.Write("    ");

                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.SetCursorPosition(40, 17);
                                Console.Write("JUEGO MATEMÁTICO");
                                Console.BackgroundColor = ConsoleColor.Black;

                                Console.SetCursorPosition(35, 17);
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.Write("--->");
                                Console.BackgroundColor = ConsoleColor.Black;

                                Console.SetCursorPosition(40, 18);
                                Console.Write("ESQUIVA LAS FLECHAS");
                                Console.BackgroundColor = ConsoleColor.Black;

                                Console.SetCursorPosition(40, 19);
                                Console.Write("SALIR");
                                Console.BackgroundColor = ConsoleColor.Black;

                                Console.SetCursorPosition(40, 17);
                            }
                            else
                            {
                                if (contadorMenu == 3)
                                {
                                    Console.SetCursorPosition(40, 12);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("BIENVENIDO, SELECCIONE UN JUEGO");
                                    Console.SetCursorPosition(40, 13);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("--------------------------------");

                                    Console.SetCursorPosition(40, 15);
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.Write("AHORCADO");

                                    Console.SetCursorPosition(40, 16);
                                    Console.Write("ANAGRAMAS");
                                    Console.BackgroundColor = ConsoleColor.Black;

                                    Console.SetCursorPosition(40, 17);
                                    Console.Write("JUEGO MATEMÁTICO");
                                    Console.BackgroundColor = ConsoleColor.Black;

                                    Console.SetCursorPosition(35, 17);
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.Write("    ");

                                    Console.BackgroundColor = ConsoleColor.Red;
                                    Console.SetCursorPosition(40, 18);
                                    Console.Write("ESQUIVA LAS FLECHAS");
                                    Console.BackgroundColor = ConsoleColor.Black;

                                    Console.SetCursorPosition(35, 18);
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.Write("--->");
                                    Console.BackgroundColor = ConsoleColor.Black;

                                    Console.SetCursorPosition(40, 19);
                                    Console.Write("SALIR");
                                    Console.BackgroundColor = ConsoleColor.Black;

                                    Console.SetCursorPosition(40, 18);
                                }
                                else
                                {
                                    if (contadorMenu == 4)
                                    {
                                        Console.SetCursorPosition(40, 12);
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("BIENVENIDO, SELECCIONE UN JUEGO");
                                        Console.SetCursorPosition(40, 13);
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("--------------------------------");

                                        Console.SetCursorPosition(40, 15);
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.Write("AHORCADO");

                                        Console.SetCursorPosition(40, 16);
                                        Console.Write("ANAGRAMAS");
                                        Console.BackgroundColor = ConsoleColor.Black;


                                        Console.SetCursorPosition(40, 17);
                                        Console.Write("JUEGO MATEMÁTICO");
                                        Console.BackgroundColor = ConsoleColor.Black;

                                        Console.SetCursorPosition(40, 18);
                                        Console.Write("ESQUIVA LAS FLECHAS");
                                        Console.BackgroundColor = ConsoleColor.Black;

                                        Console.SetCursorPosition(35, 18);
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.Write("    ");

                                        Console.BackgroundColor = ConsoleColor.Red;
                                        Console.SetCursorPosition(40, 19);
                                        Console.Write("SALIR");
                                        Console.BackgroundColor = ConsoleColor.Black;

                                        Console.SetCursorPosition(35, 19);
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.Write("--->");

                                        Console.BackgroundColor = ConsoleColor.Black;

                                        Console.SetCursorPosition(40, 19);
                                    }
                                }
                            }
                        }
                        break;

                    // DIRECCION FLECHAS ARRIBA

                    case ConsoleKey.UpArrow:

                        if (contadorMenu > 0)
                            contadorMenu--;

                        if (contadorMenu == 0)
                        {
                            Console.SetCursorPosition(40, 12);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("BIENVENIDO, SELECCIONE UN JUEGO");
                            Console.SetCursorPosition(40, 13);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("--------------------------------");

                            Console.SetCursorPosition(40, 15);
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Write("AHORCADO");

                            Console.SetCursorPosition(35, 15);
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Write("--->");
                            Console.BackgroundColor = ConsoleColor.Black;

                            Console.SetCursorPosition(40, 16);
                            Console.Write("ANAGRAMAS");
                            Console.BackgroundColor = ConsoleColor.Black;

                            Console.SetCursorPosition(35, 16);
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Write("    ");

                            Console.SetCursorPosition(40, 17);
                            Console.Write("JUEGO MATEMÁTICO");
                            Console.BackgroundColor = ConsoleColor.Black;

                            Console.SetCursorPosition(40, 18);
                            Console.Write("ESQUIVA LAS FLECHAS");
                            Console.BackgroundColor = ConsoleColor.Black;

                            Console.SetCursorPosition(40, 19);
                            Console.Write("SALIR");
                            Console.BackgroundColor = ConsoleColor.Black;

                            Console.SetCursorPosition(40, 15);
                        }
                        else
                        {
                            if (contadorMenu == 1)
                            {
                                Console.SetCursorPosition(40, 12);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("BIENVENIDO, SELECCIONE UN JUEGO");
                                Console.SetCursorPosition(40, 13);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("--------------------------------");

                                Console.SetCursorPosition(40, 15);
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.Write("AHORCADO");

                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.SetCursorPosition(40, 16);
                                Console.Write("ANAGRAMAS");
                                Console.BackgroundColor = ConsoleColor.Black;

                                Console.SetCursorPosition(35, 16);
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.Write("--->");
                                Console.BackgroundColor = ConsoleColor.Black;

                                Console.SetCursorPosition(40, 17);
                                Console.Write("JUEGO MATEMÁTICO");
                                Console.BackgroundColor = ConsoleColor.Black;

                                Console.SetCursorPosition(35, 17);
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.Write("    ");

                                Console.SetCursorPosition(40, 18);
                                Console.Write("ESQUIVA LAS FLECHAS");
                                Console.BackgroundColor = ConsoleColor.Black;

                                Console.SetCursorPosition(40, 19);
                                Console.Write("SALIR");
                                Console.BackgroundColor = ConsoleColor.Black;

                                Console.SetCursorPosition(40, 16);
                            }
                            else
                            {
                                if (contadorMenu == 2)
                                {
                                    Console.SetCursorPosition(40, 12);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("BIENVENIDO, SELECCIONE UN JUEGO");
                                    Console.SetCursorPosition(40, 13);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("--------------------------------");

                                    Console.SetCursorPosition(40, 15);
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.Write("AHORCADO");

                                    Console.SetCursorPosition(40, 16);
                                    Console.Write("ANAGRAMAS");
                                    Console.BackgroundColor = ConsoleColor.Black;

                                    Console.BackgroundColor = ConsoleColor.Red;
                                    Console.SetCursorPosition(40, 17);
                                    Console.Write("JUEGO MATEMÁTICO");
                                    Console.BackgroundColor = ConsoleColor.Black;

                                    Console.SetCursorPosition(35, 17);
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.Write("--->");
                                    Console.BackgroundColor = ConsoleColor.Black;

                                    Console.SetCursorPosition(40, 18);
                                    Console.Write("ESQUIVA LAS FLECHAS");
                                    Console.BackgroundColor = ConsoleColor.Black;

                                    Console.SetCursorPosition(35, 18);
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.Write("    ");

                                    Console.SetCursorPosition(40, 19);
                                    Console.Write("SALIR");
                                    Console.BackgroundColor = ConsoleColor.Black;

                                    Console.SetCursorPosition(40, 17);
                                }
                                else
                                {
                                    if (contadorMenu == 3)
                                    {
                                        Console.SetCursorPosition(40, 12);
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("BIENVENIDO, SELECCIONE UN JUEGO");
                                        Console.SetCursorPosition(40, 13);
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("--------------------------------");

                                        Console.SetCursorPosition(40, 15);
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.Write("AHORCADO");

                                        Console.SetCursorPosition(40, 16);
                                        Console.Write("ANAGRAMAS");
                                        Console.BackgroundColor = ConsoleColor.Black;

                                        Console.SetCursorPosition(40, 17);
                                        Console.Write("JUEGO MATEMÁTICO");
                                        Console.BackgroundColor = ConsoleColor.Black;

                                        Console.BackgroundColor = ConsoleColor.Red;
                                        Console.SetCursorPosition(40, 18);
                                        Console.Write("ESQUIVA LAS FLECHAS");
                                        Console.BackgroundColor = ConsoleColor.Black;

                                        Console.SetCursorPosition(35, 18);
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.Write("--->");
                                        Console.BackgroundColor = ConsoleColor.Black;

                                        Console.SetCursorPosition(40, 19);
                                        Console.Write("SALIR");
                                        Console.BackgroundColor = ConsoleColor.Black;

                                        Console.SetCursorPosition(35, 19);
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.Write("    ");

                                        Console.SetCursorPosition(40, 18);
                                    }
                                }
                            }
                        }
                        break;
                }

                option = Console.ReadKey(true);
            }

            return contadorMenu;
        }

        public static void Jugar(int numeroJuego, ref bool exit)
        {
            Ahorcado ahorcado = new Ahorcado();
            EsquivaFlechas esquivaFlechas = new EsquivaFlechas();

            Console.Clear();

            switch(numeroJuego)
            {
                case 0:
                    ahorcado.Jugar();
                    break;
                case 3:
                    esquivaFlechas.MovimientoFlechaDcha();
                    break;
                case 4:
                    exit = true;

                    break;
            }
        }

        static void Main(string[] args)
        {
            bool exit = false;

            while(exit == false)
            {
                Jugar(MainMenu(), ref exit);
            }

            Console.SetCursorPosition(40, 12);
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("GRACIAS POR JUGAR");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
