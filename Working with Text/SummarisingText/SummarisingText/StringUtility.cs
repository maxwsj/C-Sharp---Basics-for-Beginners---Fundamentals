using System;
using System.Collections.Generic;
using System.Text;

namespace SummarisingText
{
    public class StringUtility
    {
        // Creating a new Method (static) in order to call this method from the main method we need to declare it as static
        public static string SummerizeText(string text, int maxLength = 20)
        {
            // First we check if the length of the sentence is below the threshold if that's the casae we simply display it

            if (text.Length < maxLength)
                return text;

            /////////// How to we summarize this ? ////////////
            // The first thing we need to do is split aand we use the whitespace as a separetor
            var words = text.Split(' '); // Now we have a string array of words

            // We can iterate over this array for eacah word we count the length of that word and add all them together
            // If we roughly get around 20 or exit 20 that's a boundary where we need to cut.
            var totalCharacters = 0;

            // We need a list to dynamically store all these words
            var summaryWords = new List<string>();

            foreach (var word in words)
            {
                summaryWords.Add(word);

                // For each word we get it's length and we add it to total characters
                totalCharacters += word.Length + 1; // The one here is because the space of that word

                if (totalCharacters > maxLength)
                    break;
            }

            // Now we need to create a string and join alal these words using whitespace. How do we do that ?

            return String.Join(" ", summaryWords) + "...."; // returns a summary string;
        }
    }
}
