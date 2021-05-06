using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ProjectX
{
    class EsquivaFlechas
    {
        public string flechaIzq = "<--";
        public string flechaDcha = "-->";
        List<string> flechasDcha;

        public EsquivaFlechas()
        {
            this.flechaDcha = "-->";
            this.flechaIzq = "<--";
            flechasDcha = new List<string>();
        }

        public string GetFlechaDcha()
        {
            return flechaDcha;
        }

        public void SetFlechaDcha(string nuevaFlechaDcha)
        {
            flechaDcha = nuevaFlechaDcha;
        }

        /*   public void MoverFlechas()
           {
               int ancho = Console.WindowWidth;
               int alto = Console.WindowHeight;

               for (int i = 0; i <= ancho; i++)
               {
                   Console.Clear();
                   Console.SetCursorPosition(i, 10);
                   Console.WriteLine(flechaDcha);
                   Thread.Sleep(500);
               }
           }*/

        public void Mapa()
        {
            for (int i = 0; i < 26; i++)
            {
                for (int j = 0; j < 101; j++)
                {
                    if ((i > 1 && i < 24) && (j > 2 && j < 98))
                    {
                        Console.SetCursorPosition(j, i);
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.SetCursorPosition(j, i);
                        Console.Write("#");
                    }
                }
            }
        }

        public void MovimientoFlechaDcha()
        {
            Random y = new Random();

            int altura = y.Next(3, 24);

            for(int i = 1; i < 100; i++)
            {
                if (i == 99)
                {
                    i = 1;
                    SetFlechaDcha("-->");
                }
                if (i <= 3)
                {
                    Console.SetCursorPosition(i - 1, altura);
                    Console.Write("#");
                }
                if (i > 3)
                {
                    Console.SetCursorPosition(i - 1, altura);
                    Console.Write(" ");
                }

                if (i > 95)
                {
                    Console.SetCursorPosition(i, altura);
                    Console.Write(CortarFlechaDcha(GetFlechaDcha()));
                    SetFlechaDcha(CortarFlechaDcha(GetFlechaDcha()));
                }
                
                Console.SetCursorPosition(i, altura);
                Console.Write(GetFlechaDcha());
                Thread.Sleep(10);
            }
            

        }

        public string CortarFlechaDcha(string felchaDcha)
        {
            string nuevaFlecha = "";

            for (int i = 0; i < flechaDcha.Length - 1; i++)
            {
                nuevaFlecha += Convert.ToString(flechaDcha[i]);
            }

            return nuevaFlecha;
        }
    }
}
