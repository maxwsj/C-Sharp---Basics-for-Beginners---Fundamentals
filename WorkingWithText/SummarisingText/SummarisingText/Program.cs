using System;
using System.Collections.Generic;

namespace SummarisingText
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Morbi vitae rhoncus risus, vel tempor erat.";
            var summaary = StringUtility.SummerizeText(sentence, 50);
            Console.WriteLine(summaary);
        }
        

    }
}
