using System;

namespace ArrayManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                CharacterArray charArray = new CharacterArray(3, 4);

                // Test indexer
                Console.WriteLine("Row 0: " + charArray[0]);
                Console.WriteLine("Row 1: " + charArray[1]);
                Console.WriteLine("Row 2: " + charArray[2]);
                try
                {
                    Console.WriteLine("Row 3 (invalid): " + charArray[3]);
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine("Caught error: " + e.Message);
                }


                Console.WriteLine("Number of consonants: " + charArray.ConsonantCount);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}