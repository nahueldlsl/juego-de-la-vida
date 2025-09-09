namespace Library;

public class Next_gen
{
    public void CalcularGen(Tablero matriz)
    {
        Tablero gameBoard = matriz;
        int boardWidth = matriz.Ancho;
        int boardHeight = matriz.Alto;

        Tablero cloneboard = new Tablero(boardWidth, boardHeight);
        for (int x = 0; x < boardWidth; x++)
        {
            for (int y = 0; y < boardHeight; y++)
            {
                int aliveNeighbors = 0;
                for (int i = x-1; i<=x+1;i++)
                {
                    for (int j = y-1;j<=y+1;j++)
                    {
                        if(i>=0 && i<boardWidth && j>=0 && j < boardHeight && gameBoard.CelulaViva(i,j))
                        {
                            aliveNeighbors++;
                        }
                    }
                }
                if(gameBoard.CelulaViva(x,y))
                {
                    aliveNeighbors--;
                }
                if (gameBoard.CelulaViva(x,y) && aliveNeighbors < 2)
                {
                    //Celula muere por baja población
                    cloneboard.SetAlive(x,y, false);
                }
                else if (gameBoard.CelulaViva(x,y) && aliveNeighbors > 3)
                {
                    //Celula muere por sobrepoblación
                    cloneboard.SetAlive(x,y,false);
                }
                else if (!gameBoard.CelulaViva(x,y) && aliveNeighbors == 3)
                {
                    //Celula nace por reproducción
                    cloneboard.SetAlive(x,y, true);
                }
                else
                {
                    //Celula mantiene el estado que tenía
                    cloneboard.SetAlive(x,y, gameBoard.CelulaViva(x,y));
                }
            }
        }
        matriz = cloneboard;
    }
}