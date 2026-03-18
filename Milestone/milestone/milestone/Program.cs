using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace milestone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get user inputs line by line
            string mainString = GetInput("");
            string substring = GetInput("");
            char charToReplace = GetInput("")[0];
            char replacementChar = GetInput("")[0];

            // Process the logic
            bool substringExists = CheckSubstringExists(mainString, substring);
            string replacedString = ReplaceCharacter(mainString, charToReplace, replacementChar);
            string caseSwapped = SwapCase(mainString);
            string noSpaces = RemoveWhitespace(mainString);
            Dictionary<char, int> letterCount = CountLetters(mainString);

            // Print the final results
            Console.WriteLine($"Substring Exists: {(substringExists ? "Yes" : "No")}");
            Console.WriteLine($"Replaced: {replacedString}");
            Console.WriteLine($"Case Swapped: {caseSwapped}");
            Console.WriteLine($"No Spaces: {noSpaces}");
            Console.WriteLine($"Letter Count: {string.Join(", ", letterCount.Select(kvp => $"{kvp.Key}: {kvp.Value}"))}");
        }

        static string GetInput(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

        // 1. Check if substring exists
        static bool CheckSubstringExists(string main, string sub)
        {
            // --- WRITE THIS ---
            return main.Contains(sub);
        }

        // 2. Replace specific character
        static string ReplaceCharacter(string input, char oldChar, char newChar)
        {
            // --- WRITE THIS ---
            return input.Replace(oldChar, newChar);
        }

        // 3. Swap uppercase to lowercase and vice versa
        static string SwapCase(string input)
        {
            // --- WRITE THIS ---
            char[] result = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsUpper(input[i]))
                    result[i] = char.ToLower(input[i]);
                else if (char.IsLower(input[i]))
                    result[i] = char.ToUpper(input[i]);
                else
                    result[i] = input[i];
            }

            return new string(result);
        }

        // 4. Remove all whitespace characters (Manual Version)
        static string RemoveWhitespace(string input)
        {
            // --- WRITE THIS ---
            char[] temp = new char[input.Length];
            int index = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (!char.IsWhiteSpace(input[i]))
                {
                    temp[index] = input[i];
                    index++;
                }
            }

            return new string(temp, 0, index);
        }

        // 5. Count occurrences of each letter
        static Dictionary<char, int> CountLetters(string input)
        {
            // --- WRITE THIS ---
            Dictionary<char, int> count = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    if (count.ContainsKey(c))
                        count[c]++;
                    else
                        count[c] = 1;
                }
            }

            return count;
        }
    }
}
    
