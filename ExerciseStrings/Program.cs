using System;

namespace ExerciseStrings
{
    class Program
    {
        private static void Main()
        {
            string aliceText = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            string modifiedBegining;
            string modifiedEnd;
            string searchTerm;
            
            Console.WriteLine("Enter a search term:");
            searchTerm = Console.ReadLine().ToLower();
            
            if (aliceText.ToLower().IndexOf(searchTerm) > -1)
            {
                Console.WriteLine("Index: " + aliceText.ToLower().IndexOf(searchTerm) + " Length: " + searchTerm.Length);
                modifiedBegining = (aliceText.Substring(0, aliceText.ToLower().IndexOf(searchTerm)));
                modifiedEnd = aliceText.Substring(modifiedBegining.Length + searchTerm.Length, aliceText.Length - (modifiedBegining.Length + searchTerm.Length));
                Console.WriteLine(modifiedBegining + modifiedEnd);
            }

        }
    }
}
