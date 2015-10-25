using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TSP
{
    partial class Matrix
    {
        // Структура - элемент класса Matrix
        public struct Node
        {
            public int i;// индекс i
            public int j;// индекс j
            public int value;// значение элемента массива
        }

        Node[,] matrix;// Массив Node

        int size;

        // Конструктор, принимающий двумерный массив int
        public Matrix(int[,] source_matrix)
        {
            // Определяю размер массива
            size = (int)Math.Sqrt(source_matrix.Length);

            // Создаю массив Node - matrix
            matrix = new Node[size, size];

            // Заполняю каждый элемент массива matrix
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j].i = i;// полю i ноды присваиваю текущий индекс
                    matrix[i, j].j = j;// полю j ноды присваиваю текущий индекс
                    matrix[i, j].value = source_matrix[i, j];// полю value ноды присваиваю текущее значение source_matrix[i,j]
                }
            }
        }

        // Перегрузка оператора индексации
        public int this[int its_i, int its_j]
        {
            get
            {
                // Возвращаю инт конкретной ноды
                return matrix[its_i, its_j].value;
            }

            set
            {
                // присваиваю новое значение ноды текущей ноде
                matrix[its_i, its_j].value = value;
            }
        }
    }
}

