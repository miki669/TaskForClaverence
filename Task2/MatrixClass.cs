namespace TaskForClaverence.Task2;

public class MatrixClass
{
    public static  int[] GetElements(int[,] matrix)
    { 
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int totalElements = rows * cols;
        int[] result = new int[totalElements];
        int index = 0;

        int rowStart = 0, rowEnd = rows - 1;
        int colStart = 0, colEnd = cols - 1;

        while (index < totalElements)
        {
            for (int row = rowStart; row <= rowEnd; row++)
            {
                result[index++] = matrix[row, colStart];
            }
            colStart++;

            for (int col = colStart; col <= colEnd; col++)
            {
                result[index++] = matrix[rowEnd, col];
            }
            rowEnd--;

            if (colStart <= colEnd)
            {
                for (int row = rowEnd; row >= rowStart; row--)
                {
                    result[index++] = matrix[row, colEnd];
                }
                colEnd--;
            }

            if (rowStart <= rowEnd)
            {
                for (int col = colEnd; col >= colStart; col--)
                {
                    result[index++] = matrix[rowStart, col];
                }
                rowStart++;
            }
        }

        return result;
    
    }

    public static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    public static void PrintArray(int[] arr)
    {
        foreach (int element in arr)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
   
}