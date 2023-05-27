// See https://aka.ms/new-console-template for more information

using TaskForClaverence;
using TaskForClaverence.Task1;
using TaskForClaverence.Task2;


//Task - 1 
Console.WriteLine("TASK - 1");
string inputString = "aaabbcccdde";
string compressString = Compression.CompressString(inputString);
string decompressString = Compression.DecompressString(compressString);

Console.WriteLine($"Сжатая строка: {compressString}" );
Console.WriteLine($"Декодированая строка: {decompressString}");

// Task - 2
Console.WriteLine("TASK - 2\n");
var matrix = new int[3, 3]
{
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};
var result = MatrixClass.GetElements(matrix);

Console.WriteLine("Matrix:");
MatrixClass.PrintMatrix(matrix);

Console.WriteLine("\nResult:");
MatrixClass.PrintArray(result);
