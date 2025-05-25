using System;

namespace TextProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            TextContainer container = new TextContainer();


            container.AddString("hello world");
            container.AddString("test case");
            container.AddString("c++ programming");


            Console.WriteLine("Initial strings:");
            int index = 0;
            foreach (var text in container.GetTexts())
            {
                Console.WriteLine($"String {index++}: {text.GetValue()}, Key: {text.GetFirstChars()}");
            }


            container.UppercaseFirstLetters();
            Console.WriteLine("\nAfter capitalizing first letters:");
            index = 0;
            foreach (var text in container.GetTexts())
            {
                Console.WriteLine($"String {index++}: {text.GetValue()}, Key: {text.GetFirstChars()}");
            }


            string key = container.GetKey("quick fox jump");
            Console.WriteLine($"\nKey for 'quick fox jump': {key}");


            int count = container.GetCountOfLength(10);
            Console.WriteLine($"Number of strings with length 10: {count}");


            container.DeleteString(1);
            Console.WriteLine("\nAfter deleting string at index 1:");
            index = 0;
            foreach (var text in container.GetTexts())
            {
                Console.WriteLine($"String {index++}: {text.GetValue()}, Key: {text.GetFirstChars()}");
            }


            container.ClearText();
            Console.WriteLine("\nAfter clearing container:");
            Console.WriteLine($"Number of strings with length 11: {container.GetCountOfLength(11)}");
        }
    }
}