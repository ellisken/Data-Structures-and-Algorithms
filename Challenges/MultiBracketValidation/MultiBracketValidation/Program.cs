using StackAndQueue.Classes;
using System;

namespace MultiBracketValidation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multi-bracket Validation");
            string checkString = "y";
            while (checkString == "y")
            {
                Console.WriteLine("Please enter a string to validate:");
                string input = Console.ReadLine();
                bool result = MultiBracketValidation(input);
                if (result) Console.WriteLine("\nThe string you entered has balanced brackets.");
                else Console.WriteLine("\nThe string you entered does not have balanced brackets.");
                Console.WriteLine("\n\nWould you like to validate another string? (y/n):");
                checkString = Console.ReadLine();
                Console.WriteLine();
            }
            Console.WriteLine("Goodbye!");
        }

        /// <summary>
        /// Determines whether an input string has balanced brackets
        /// </summary>
        /// <param name="input">String to test for balanced brackets</param>
        /// <returns>True if balanced, else False. Returns true for empty strings or strings
        /// with zero brackets.</returns>
        public static bool MultiBracketValidation(string input)
        {
            //Container to store open brackets
            Stack openBrackets = new Stack(null);

            //For each char in the input string
            for(int i=0; i < input.Length; i++)
            {
                char currentChar = input[i];
                //If open bracket, push to stack
                if(currentChar == '[' || currentChar == '(' || currentChar == '{')
                {
                    openBrackets.Push(new Node(currentChar));
                }
                //Else if closing bracket, check for mate
                else if(currentChar == ']' || currentChar == ')' || currentChar == '}')
                {
                    switch (currentChar)
                    {
                        case ']':
                            if ((char)openBrackets.Pop().Value != '[') return false;
                            break;
                        case ')':
                            if ((char)openBrackets.Pop().Value != '(') return false;
                            break;
                        case '}':
                            if ((char)openBrackets.Pop().Value != '{') return false;
                            break;
                    }
                }
            }
            //If @ end of string and stack is not empty, return false
            if (openBrackets.Peek() != null) return false;
            //Otherwise the string has balanced brackets
            return true;
        }
    }
}
