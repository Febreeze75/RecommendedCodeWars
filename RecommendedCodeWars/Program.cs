using System;

namespace RecommendedCodeWars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string output = "";

            foreach (var ch in input)
            {
                if (ch != ' ')
                {
                    output += ch;
                }
            }

            return output;
        }
    }
}
