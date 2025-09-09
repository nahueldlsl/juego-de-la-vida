namespace Library;

public class Next_gen
{
    public void CalcularGen(Tablero board)
    {
        int boardWidth = board.ancho;
        int boardHeight = board.alto;

        bool[,] cloneboard = new bool[boardWidth, boardHeight];
        for (int x = 0; x < boardWidth; x++)
        {
            for (int y = 0; y < boardHeight; y++)
            {
                int aliveNeighbors = 0;
                for (int i = x-1; i<=x+1;i++)
                {
                    for (int j = y-1;j<=y+1;j++)
                    {
                        if(i>=0 && i<boardWidth && j>=0 && j < boardHeight && board[i,j])
                        {
                            aliveNeighbors++;
                        }
                    }
                }
                if(board[x,y])
                {
                    aliveNeighbors--;
                }
                if (board[x,y] && aliveNeighbors < 2)
                {
                    //Celula muere por baja población
                    cloneboard[x,y] = false;
                }
                else if (board[x,y] && aliveNeighbors > 3)
                {
                    //Celula muere por sobrepoblación
                    cloneboard[x,y] = false;
                }
                else if (!board[x,y] && aliveNeighbors == 3)
                {
                    //Celula nace por reproducción
                    cloneboard[x,y] = true;
                }
                else
                {
                    //Celula mantiene el estado que tenía
                    cloneboard[x,y] = board[x,y];
                }
            }
        }
        board = cloneboard;
    }
}