using System;

namespace ArrayManipulation
{
    public class CharacterArray
    {
        private char[,] charArray;

        public CharacterArray(int rows, int cols)
        {
            if (rows <= 0 || cols <= 0)
            {
                throw new ArgumentException("Rows and columns must be positive.");
            }
            charArray = new char[rows, cols];
            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    charArray[i, j] = (char)('a' + (i + j) % 26); 
                }
            }
        }

        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= charArray.GetLength(0))
                {
                    throw new IndexOutOfRangeException("Index out of range.");
                }
                char[] row = new char[charArray.GetLength(1)];
                for (int j = 0; j < charArray.GetLength(1); j++)
                {
                    row[j] = charArray[index, j];
                }
                return new string(row);
            }
        }

        public int ConsonantCount
        {
            get
            {
                int count = 0;
                string vowels = "aeiouAEIOU";
                for (int i = 0; i < charArray.GetLength(0); i++)
                {
                    for (int j = 0; j < charArray.GetLength(1); j++)
                    {
                        char c = charArray[i, j];
                        if (char.IsLetter(c) && vowels.IndexOf(c) == -1)
                        {
                            count++;
                        }
                    }
                }
                return count;
            }
        }
    }
}