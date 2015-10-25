using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TSP
{
    partial class Matrix
    {
        //avtor Maslakov Sergey ->
        void CreateNewMatrix(int x, int y)
        {
            int size = (int)Math.Sqrt(this.matrix.Length);
            Node[,] newMatrix = new Matrix.Node[size - 1, size - 1];
            for (int i = 0; i < size; ++i)
                for (int j = 0; j < size; ++j)
                    if (i == x || j == y)
                        continue;
                    else
                        if (i > x)
                            if (j > y)
                                newMatrix[i - 1, j - 1] = this.matrix[i, j];
                            else
                                newMatrix[i - 1, j] = this.matrix[i, j];
                        else
                            if (j > y)
                                newMatrix[i, j - 1] = this.matrix[i, j];
                            else
                                newMatrix[i, j] = this.matrix[i, j];
        }
    }
}
