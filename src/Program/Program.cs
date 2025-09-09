using System;
using System.Text;
using System.Threading;

namespace Ucu.Poo.GameOfLife
{
    public class Impresor
    {
        public void Mostrar(Tablero tablero)
        {
            while (true)
            {
                Console.Clear();
                StringBuilder s = new StringBuilder();
                for (int y = 0; y < tablero.alto; y++)
                {
                    for (int x = 0; x < tablero.ancho; x++)
                    {
                        if (tablero[x, y])
                        {
                            s.Append("|X|");
                        }
                        else
                        {
                            s.Append("___");
                        }
                    }

                    s.Append("\n");
                }

                Console.WriteLine(s.ToString());

                Thread.Sleep(300);
            }
        }
    }
}