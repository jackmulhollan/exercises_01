using System;
using System.IO;
using System.Text;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Diagnostics;


namespace PerfectVisionGolf.Controllers
{
    class myapp
    {
        static void Main(string[] args)
        {
            TestNotString();
            Console.WriteLine("--------------------------------------");
            TestMissingChar();
            Console.WriteLine("--------------------------------------");
            TestFrontBack();
            Console.WriteLine("--------------------------------------");
            TestFront3();
            Console.WriteLine("--------------------------------------");
            TestBackAround();
        }

        private static string NotString(string input) {
            // Your code goes here...

            if (input.Length >= 3 && input.Substring(0,3) == "not")
            {
                return input;
            }
            else
            {
                return "not " + input;
            }
        }

        private static string MissingChar(string input, int input2) {
            // Your code goes here...

            return input.Substring(0, input2) + input.Substring(input2 + 1, (input.Length - input2 - 1));
        }

        private static string FrontBack(string input) {
            // Your code goes here...
            if (input.Length <= 1)
            {
                return input;
            }
            else
            {
                string mid = input.Substring(1,input.Length - 2);
                return input.Substring(input.Length - 1, 1) + mid + input.Substring(0, 1);
            }
        }

        private static string Front3(string input)
        {
            // Your code goes here...

            string front3 = input.Substring(0,3);
            return front3 + front3 + front3;
        }

        private static string BackAround(string input)
        {
            // Your code goes here...

            string lastChar = input.Substring(input.Length - 1, 1);
            return lastChar + input + lastChar;
        }

        private static void TestNotString()
        {
            string name = "NotString";

            string input;
            string expectedOutput;
            string actualOutput;

            input = "candy";
            expectedOutput = "not candy";
            actualOutput = NotString(input);
            PrintResults($"{name}({input})", expectedOutput, actualOutput);

            input = "x";
            expectedOutput = "not x";
            actualOutput = NotString(input);
            PrintResults($"{name}({input})", expectedOutput, actualOutput);

            input = "not bad";
            expectedOutput = "not bad";
            actualOutput = NotString(input);
            PrintResults($"{name}({input})", expectedOutput, actualOutput);

            input = "bad";
            expectedOutput = "not bad";
            actualOutput = NotString(input);
            PrintResults($"{name}({input})", expectedOutput, actualOutput);

            input = "not";
            expectedOutput = "not";
            actualOutput = NotString(input);
            PrintResults($"{name}({input})", expectedOutput, actualOutput);

            input = "is not";
            expectedOutput = "not is not";
            actualOutput = NotString(input);
            PrintResults($"{name}({input})", expectedOutput, actualOutput);

            input = "no";
            expectedOutput = "not no";
            actualOutput = NotString(input);
            PrintResults($"{name}({input})", expectedOutput, actualOutput);
        }


        private static void TestMissingChar()
        {
            string name = "MissingChar";

            string input;
            int input2;
            string expectedOutput;
            string actualOutput;

            input = "kitten";
            input2 = 1;
            expectedOutput = "ktten";
            actualOutput = MissingChar(input, input2);
            PrintResults($"{name}({input}, {input2})", expectedOutput, actualOutput);
            
            input = "kitten";
            input2 = 0;
            expectedOutput = "itten";
            actualOutput = MissingChar(input, input2);
            PrintResults($"{name}({input}, {input2})", expectedOutput, actualOutput);
            
            input = "kitten";
            input2 = 4;
            expectedOutput = "kittn";
            actualOutput = MissingChar(input, input2);
            PrintResults($"{name}({input}, {input2})", expectedOutput, actualOutput);
            
            input = "Hi";
            input2 = 0;
            expectedOutput = "i";
            actualOutput = MissingChar(input, input2);
            PrintResults($"{name}({input}, {input2})", expectedOutput, actualOutput);
            
            input = "Hi";
            input2 = 1;
            expectedOutput = "H";
            actualOutput = MissingChar(input, input2);
            PrintResults($"{name}({input}, {input2})", expectedOutput, actualOutput);
                        
            input = "code";
            input2 = 0;
            expectedOutput = "ode";
            actualOutput = MissingChar(input, input2);
            PrintResults($"{name}({input}, {input2})", expectedOutput, actualOutput);
            
            input = "code";
            input2 = 1;
            expectedOutput = "cde";
            actualOutput = MissingChar(input, input2);
            PrintResults($"{name}({input}, {input2})", expectedOutput, actualOutput);
            
            input = "code";
            input2 = 2;
            expectedOutput = "coe";
            actualOutput = MissingChar(input, input2);
            PrintResults($"{name}({input}, {input2})", expectedOutput, actualOutput);
            
            input = "code";
            input2 = 3;
            expectedOutput = "cod";
            actualOutput = MissingChar(input, input2);
            PrintResults($"{name}({input}, {input2})", expectedOutput, actualOutput);
            
            input = "chocolate";
            input2 = 8;
            expectedOutput = "chocolat";
            actualOutput = MissingChar(input, input2);
            PrintResults($"{name}({input}, {input2})", expectedOutput, actualOutput);
        }

        private static void TestFrontBack()
        {
            string name = "FrontBack";

            string input;
            string expectedOutput;
            string actualOutput;

            input = "code";
            expectedOutput = "eodc";
            actualOutput = FrontBack(input);
            PrintResults($"{name}({input})", expectedOutput, actualOutput);

            input = "a";
            expectedOutput = "a";
            actualOutput = FrontBack(input);
            PrintResults($"{name}({input})", expectedOutput, actualOutput);

            input = "ab";
            expectedOutput = "ba";
            actualOutput = FrontBack(input);
            PrintResults($"{name}({input})", expectedOutput, actualOutput);
        }

        private static void TestFront3()
        {
            string name = "Front3";

            string input;
            string expectedOutput;
            string actualOutput;

            input = "Chocolat";
            expectedOutput = "ChoChoCho";
            actualOutput = Front3(input);
            PrintResults($"{name}({input})", expectedOutput, actualOutput);

            input = "Java";
            expectedOutput = "JavJavJav";
            actualOutput = Front3(input);
            PrintResults($"{name}({input})", expectedOutput, actualOutput);

            input = "abc";
            expectedOutput = "abcabcabc";
            actualOutput = Front3(input);
            PrintResults($"{name}({input})", expectedOutput, actualOutput);
        }

        private static void TestBackAround()
        {
            string name = "BackAround";

            string input;
            string expectedOutput;
            string actualOutput;

            input = "Cat";
            expectedOutput = "tCatt";
            actualOutput = BackAround(input);
            PrintResults($"{name}({input})", expectedOutput, actualOutput);

            input = "Hello";
            expectedOutput = "oHelloo";
            actualOutput = BackAround(input);
            PrintResults($"{name}({input})", expectedOutput, actualOutput);

            input = "a";
            expectedOutput = "aaa";
            actualOutput = BackAround(input);
            PrintResults($"{name}({input})", expectedOutput, actualOutput);
        }
        private static void PrintResults(string methodCall, string expected, string actual)
        {
            string result = (expected == actual) ? "Pass" : "Fail ***";
            Console.WriteLine($"{methodCall} --> {expected} | {actual} --> {result}");
        }

    }
}



