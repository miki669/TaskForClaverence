using System.Text;

namespace TaskForClaverence.Task1;

public class Compression
{
   public static string CompressString(string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;

        StringBuilder compressed = new StringBuilder();
        int count = 1;
        char prevChar = input[0];

        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] == prevChar)
            {
                count++;
            }
            else
            {
                compressed.Append(FormatGroup(prevChar, count));
                prevChar = input[i];
                count = 1;
            }
        }

        compressed.Append(FormatGroup(prevChar, count));

        return compressed.ToString();
    }
   private static string FormatGroup(char character, int count)
   {
       if (count == 1)
       {
           return character.ToString();
       }
       else
       {
           return $"{character}{count}";
       }
   }
   public static string DecompressString(string compressed)
    {
        if (string.IsNullOrEmpty(compressed))
            return compressed;

        StringBuilder decompressed = new StringBuilder();
        int i = 0;

        while (i < compressed.Length)
        {
            char currentChar = compressed[i];

            if (char.IsDigit(currentChar))
            {
                int count = int.Parse(currentChar.ToString());
                char repeatedChar = decompressed[^1];
                decompressed.Append(new string(repeatedChar, count-1));
            }
            else
            {
                decompressed.Append(currentChar);
            }

            i++;
        }

        return decompressed.ToString();
    }
  
}