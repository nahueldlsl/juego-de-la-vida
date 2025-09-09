using System.Dynamic;

namespace Library;

public class Tablero
{
    public int Ancho { get; private set; }
    public int Alto { get; private set; }

    private bool[,] matriz;

    public Tablero(int ancho, int alto)
    {
        this.Ancho = ancho;
        this.Alto = alto;
        this.matriz = new bool [ancho, alto];
    }

    public bool CelulaViva(int x, int y)
    {
        return matriz[x, y];
    }

    public void SetAlive(int x, int y, bool cambio)
    {
        matriz[x, y] = cambio;
    }

}
