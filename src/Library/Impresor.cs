using System;
using System.Text;
using System.Threading;

namespace Library;

    public class Impresor
    {
        public void Mostrar(Tablero board)
        {
            while (true)
            {
                Console.Clear();
                StringBuilder s = new StringBuilder();
                for (int y = 0; y < board.Alto; y++)
                {
                    for (int x = 0; x < board.Ancho; x++)
                    {
                        if (board.CelulaViva(x,y))
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
                Next_gen nextGen = new Next_gen();
                nextGen.CalcularGen(board);
                Thread.Sleep(300);
            }
        }
    }

