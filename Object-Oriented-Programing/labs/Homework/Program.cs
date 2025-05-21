using System;

namespace ArrayManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Create a 3x4 character array
                CharacterArray charArray = new CharacterArray(3, 4);

                // Test indexer
                Console.WriteLine("Row 0: " + charArray[0]);
                Console.WriteLine("Row 1: " + charArray[1]);
                Console.WriteLine("Row 2: " + charArray[2]);
                try
                {
                    Console.WriteLine("Row 3 (invalid): " + charArray[3]); // Should throw
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine("Caught error: " + e.Message);
                }

                // Test ConsonantCount property
                Console.WriteLine("Number of consonants: " + charArray.ConsonantCount);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}