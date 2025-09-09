using System;
using Library;

namespace Ucu.Poo.GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            Lector lector = new Lector();
            Tablero tablero = lector.Leer("board.txt");
            Impresor impresor = new Impresor();
            impresor.Mostrar(tablero);
        }
    }
}

