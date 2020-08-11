using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class GameLogic
    {
        // Fields

        public int CurGeneration { get; private set; }
        private int Rows;
        private int Columns;
        private bool[,] Field;

        // Ctors

        protected GameLogic() { }

        public GameLogic(int rows, int columns, int density = 2)
        {
            Rows = rows;
            Columns = columns;
            Field = new bool[Columns, Rows];

            Random random = new Random();
            for (int x = 0; x < Columns; x++)
            {
                for (int y = 0; y < Rows; y++)
                {
                    Field[x, y] = random.Next(density) == 0;
                }
            }
        }

        // Methods

        public void Generation()
        {
            bool[,] NewField = Field;

            for (int x = 0; x < Columns; x++)
            {
                for (int y = 0; y < Rows; y++)
                {
                    int countNeighbors = CountOfNeighbors(x, y);
                    bool HaseLife = NewField[x, y];

                    if (!HaseLife && countNeighbors == 3)
                        NewField[x, y] = true;
                    else if (HaseLife && (countNeighbors < 2 || countNeighbors > 3))
                        NewField[x, y] = false;
                }
            }

            Field = NewField;
            CurGeneration++;
        }

        private int CountOfNeighbors(int x, int y)
        {
            int count = 0;

            for (int i = -1; i < 2; i++)
            {
                for (int k = -1; k < 2; k++)
                {
                    int colum = (x + i + Columns) % Columns;
                    int row = (y + k + Rows) % Rows;

                    bool selfChecking = colum == x && row == y;
                    bool HasLife = Field[colum, row];


                    if (HasLife && !selfChecking)
                        count++;
                }
            }

            return count;
        }

        public bool[,] GetGeneration()
        {
            bool[,] GetField = new bool[Columns, Rows];

            for (int x = 0; x < Columns; x++)
            {
                for (int y = 0; y < Rows; y++)
                {
                    GetField[x, y] = Field[x, y];
                }
            }

            return GetField;
        }
    }
}
