using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ProjectX
{
    class Ahorcado
    {
        List<string> palabras;
        int indice = 0;
        string estado;
        int estadoAhorcado;
        public Ahorcado()
        {
            palabras = new List<string>();

            palabras.Add("intermitente");
            palabras.Add("farola");
            palabras.Add("olivo");
            palabras.Add("rupestre");
            palabras.Add("policia");
            palabras.Add("tenista");
            palabras.Add("exterminador");
            palabras.Add("sillon");
            palabras.Add("garaje");
            palabras.Add("boquete");
            palabras.Add("geranio");
            palabras.Add("bombilla");
            palabras.Add("electricidad");
            palabras.Add("jabali");
            palabras.Add("persiana");
            palabras.Add("sulfato");
            palabras.Add("mentecato");

            estadoAhorcado = 6;
        }

        public string GetEstado()
        {
            return estado;
        }

        public void SetEstado(string nuevoEstado)
        {
            estado = nuevoEstado;
        }

        public int GetIndice()
        {
            return indice;
        }

        public void SetIndice(int nuevoIndice)
        {
            indice = nuevoIndice;
        }

        public void Jugar()
        {
            Random numeroAleatorio = new Random();
            string letra;

            indice = numeroAleatorio.Next(0, palabras.Count);

            DibujaPalabra();

            Console.WriteLine("");

            while (estadoAhorcado > 0 && GetEstado() != palabras[indice])
            {
                Console.Write("Introduzca letra: ");
                letra = Console.ReadLine();

                ActualizarPalabra(letra);

                Console.WriteLine("");

                if (estadoAhorcado == 0)
                {
                    Console.WriteLine("¡PERDISTE!");
                    Thread.Sleep(3000);
                }

                if (GetEstado() == palabras[indice])
                {
                    Console.WriteLine("¡HAS GANADO!");
                    Thread.Sleep(3000);
                }
            }

            SetIndice(6);
            Console.Clear();
        }

        public void AddPalabra(string nuevaPalabra)
        {
            palabras.Add(nuevaPalabra);
        }

        public void DibujaPalabra()
        {
            estado = new string('_', palabras[indice].Length);
            Console.Write(estado);
        }

        public void DibujaAhorcado()
        {
            estadoAhorcado -= 1;
        }

        public void ActualizarPalabra(string letra)
        {
            int letraBuscar, letraBuscar1 = 0;
            string subcadenaEstado;

            letraBuscar = palabras[indice].IndexOf(letra);

            if (letraBuscar >= 0)
            {
                estado = estado.Remove(letraBuscar, 1);
                estado = estado.Insert(letraBuscar, letra);

                SetEstado(estado);

                while (letraBuscar1 >= 0 && letraBuscar <= estado.Length - 1)
                {
                    subcadenaEstado = palabras[indice].Substring(letraBuscar + 1, (estado.Length - 1) - (letraBuscar));
                    letraBuscar1 = subcadenaEstado.IndexOf(letra);

                    if (letraBuscar1 >= 0)
                    {
                        estado = estado.Remove(letraBuscar + letraBuscar1 + 1, 1);
                        estado = estado.Insert(letraBuscar + letraBuscar1 + 1, letra);

                        SetEstado(estado);

                        letraBuscar += letraBuscar1 + 2;
                    }
                }
            }
            else
            {
                Console.WriteLine("LA PALABRA NO CONTIENE LA LETRA \"{0}\"", letra);
                estadoAhorcado -= 1;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Te quedan {0} vidas", estadoAhorcado);
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.Write(GetEstado());

            // + " | ");
            // Console.Write(palabras[indice]);

            Console.WriteLine("");
        }

        public void MostrarPalabras()
        {
            foreach (string s in palabras)
            {
                Console.WriteLine(s);
            }
        }
    }
}
