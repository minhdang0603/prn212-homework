using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise1();
            //Exercise2();
            //Exercise3();
            //Exercise4();
            //Exercise5();
            //Exercise6();
            //Exercise7();
            //Exercise8();
            //Exercise9();
            //Exercise10();
            //Exercise11();
            //Exercise12();
            //Exercise13();
            //Exercise14();
            //Exercise15();
            //Exercise16();
            //Exercise17();
            //Exercise18();
            //Exercise19();
            //Exercise20();
            //Exercise21();
            //Exercise22();
            //Exercise23();
            //Exercise24();
            //Exercise25();
            Exercise26();

            Console.ReadKey();
        }

        //Write a C# Sharp program to print Hello and your name in a separate line.
        static void Exercise1()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Ta Minh Dang");
        }

        //Write a C# Sharp program to print the results of the specified operations.
        static void Exercise2()
        {
            Console.WriteLine(-1 + 4 * 6);
            Console.WriteLine((35 + 5) % 7);
            Console.WriteLine(14 + -4 * 6 / 11);
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
        }

        //Write a C# Sharp program to swap two numbers.
        static void Exercise3()
        {
            Console.Write("Input the first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Input the secon number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            swapNumber(ref firstNumber, ref secondNumber);

            Console.WriteLine("After Swapping:");
            Console.WriteLine("First Number: {0}", firstNumber);
            Console.WriteLine("Second Number: {0}", secondNumber);

            // swap function
            void swapNumber(ref int a, ref int b)
            {
                int tmp = a;
                a = b;
                b = tmp;
            }
        }

        //Write a C# program that takes a number as input
        //and displays it four times in a row (separated by blank spaces),
        //and then four times in the next row, with no separation.
        //You should do it twice: Use the console. Write and use {0}.
        static void Exercise4()
        {
            Console.Write("Enter a digit: ");
            int digit = int.Parse(Console.ReadLine());
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("{0} {0} {0} {0}", digit);
                Console.WriteLine("{0}{0}{0}{0}", digit);
            }
        }

        //Write a C# program that takes a number as input 
        //and displays a rectangle of 3 columns wide and 5 rows tall using that digit.
        static void Exercise5()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < 5; i++)
            {
                if (i == 0 || i == 4)
                {
                    Console.WriteLine("{0}{0}{0}", number);
                } else if (i != 0 && i != 4) 
                {
                    Console.WriteLine("{0} {0}", number);
                }
            } 
        }

        //Write a C# program to convert Celsius degrees to Kelvin and Fahrenheit
        static void Exercise6()
        {
            Console.Write("Enter the amount of celsius: ");
            double celsius = double.Parse(Console.ReadLine());
            Console.WriteLine("Kelvin = " + CelsiusToKelvin(celsius));
            Console.WriteLine("Fahrenheit = " + CelsiusToFahrenheit(celsius));

            double CelsiusToKelvin(double celsius)
            {
                // Conversion formula from Celsius to Kelvin
                return celsius + 273.15;
            }

            double CelsiusToFahrenheit(double celsius)
            {
                // Conversion formula from Celsius to Fahrenheit
                return (celsius * 9 / 5) + 32;
            }
        }

        //Write a C# program that removes a specified character from a non-empty string using the index of a character.
        static void Exercise7()
        {
            Console.WriteLine(removeChar("w3resource", 1));
            Console.WriteLine(removeChar("w3resource", 9));
            Console.WriteLine(removeChar("w3resource", 0));
            string removeChar(string str, int index)
            {
                return str.Remove(index, 1);
            }
        }

        //Write a C# program to create a new string from a given string 
        //where the first and last characters change their positions.
        static void Exercise8()
        {
            Console.WriteLine(swapFirstCharAndLastChar("x"));
            string swapFirstCharAndLastChar(string str) {
                return str.Length > 1
                    ? str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1)
                    : str;
            }
        
        }

        //Write a C# program to get the absolute value of the difference between two given numbers
        //Return double the absolute value of the difference if the first number is greater than the second number.
        static void Exercise9()
        {

            Console.WriteLine(result(13, 40));
            Console.WriteLine(result(50, 21));
            Console.WriteLine(result(0, 23));

            int result(int a, int b)
            {
                if(a > b)
                {
                    return (a - b) * 2;
                } else
                {
                    return b - a;
                }
            }
        }

        //Write a C# program to check if the given integer is within 20 of 100 or 200.
        static void Exercise10()
        {
            Console.Write("Enter an integer: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Abs(number - 100) <= 20 || Math.Abs(number-200) <= 20);
        }

        //Write a C# program to find the longest word in a string
        static void Exercise11()
        {
            string line = "Splitting the string into words based on spaces and storing them in an array";
            string[] words = line.Split(new[] {" "}, StringSplitOptions.None);

            string tmp = "";
            int cnt = 0;

            foreach(string word in words)
            {
                if(word.Length > cnt)
                {
                    tmp = word;
                    cnt = word.Length;
                }
            }

            Console.WriteLine(tmp);
        }

        //Write a C# program to reverse the words of a sentence
        static void Exercise12()
        {
            string line = "Display the pattern like pyramid using the alphabet.";
            Console.WriteLine("Original string: " + line);
            string reverse = "";
            string[] words = line.Split(new[] { " " }, StringSplitOptions.None);
            for (int i = words.Length - 1; i >= 0; i--)
            {
                reverse += words[i] + " ";
            }

            Console.Write("Reverse string: " + reverse.Trim());
        }

        //Write a C# program to find the size of a specified file in bytes
        static void Exercise13()
        {
            FileInfo f = new FileInfo("D:\\FPT\\SWP391/HE181967_Tạ Minh Đăng.docx");

            Console.WriteLine("Size of a file: " + f.Length.ToString());
        }

        //Write a C# program to convert a hexadecimal number to a decimal number.
        static void Exercise14()
        {
            string hexval = "ABC";
            Console.WriteLine("Hexadecimal number: " + hexval);
            int decValue = Convert.ToInt32(hexval, 16);
            Console.WriteLine("Convert to-");
            Console.WriteLine("Decimal number: " + decValue);
        }

        //Write a C# program to create a string of four copies, taking the last four characters from a given string. 
        //If the given string is less than 4, return the original one.
        static void Exercise15()
        {
            Console.Write("Input a string: ");
            string str = Console.ReadLine();
            Console.WriteLine(duplicate(str));
            string duplicate(string str)
            {
                if (str.Length < 4)
                {
                    return str;
                } else
                {
                    string tmp = "";
                    string res = str.Substring(str.Length-4);
                    for (int i = 0; i < 4; i++)
                    {
                        tmp += res;
                    }
                    return tmp;
                }
            }
        }

        //Write a C# program to check if a string starts with a specified word.
        static void Exercise16()
        {
            Console.Write("Input a string: ");
            string str = Console.ReadLine();
            Console.WriteLine((str.Length < 6 && str.Equals("Hello")) || (str.StartsWith("Hello") && str[5] == ' '));
        }

        //Write a C# program to check if an integer (from the two given integers) is in the range -10 to 10.
        static void Exercise17()
        {
            Console.Write("Input a first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Input a second number: ");
            int num2 = int.Parse(Console.ReadLine());

            // Check if any of the integers is in the range -10 to 10
            Console.WriteLine(IsInRange(num1) || IsInRange(num2));

            bool IsInRange(int number)
            {
                return number >= -10 && number <= 10;
            }
        }

        //Write a C# program that checks the nearest value of 20 of two given integers and return 0 if two numbers are same.
        static void Exercise18()
        {
            Console.Write("Input first integer: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Input secon integer: ");
            int second = int.Parse(Console.ReadLine());

            int n = 20;

            int val1 = Math.Abs(n - first);
            int val2 = Math.Abs(n - second);
            Console.WriteLine(first == second ? 0 : (val1 < val2 ? first : second));
        }

        //Write a C# program to check if a given string contains the 'w' character between 1 and 3 times
        static void Exercise19()
        {
            Console.Write("Input a string (contains at least one 'w' char) : ");
            string input = Console.ReadLine();
            var count = input.Count(s => s == 'w');
            Console.WriteLine(count >= 1 && count <= 3);
        }

        //Write a C# program to rotate an array (length 3) of integers in the left direction.
        static void Exercise20()
        {
            int[] nums = { 1, 2, 8 };
            Console.WriteLine("Array 1: [{0}]", string.Join(", ", nums));
            var tmp = nums[0];
            for (int i = 0; i < nums.Length - 1; i++)
            {
                nums[i] = nums[i + 1];
            }
            nums[nums.Length - 1] = tmp;
            Console.WriteLine("Array 2: [{0}]", string.Join(", ", nums));
        }

        //Write a C# Sharp program to check whether the average value of the elements of a given array of numbers is a whole number or not.
        static void Exercise21()
        {
            int[] nums = { 1, 2, 3, 5, 4, 2, 3, 4 };
            // Displays whether the average value of the array is a whole number or not
            Console.WriteLine("Check the average value of the said array is a whole number or not: " + test(nums));

            int[] nums1 = { 2, 4, 2, 6, 4, 8 };
            Console.WriteLine("Check the average value of the said array is a whole number or not: " + test(nums1));

            bool test(int[] arr_nums)
            {
                // Calculates the average value of the array using LINQ's Average() method
                // Checks if the remainder when divided by 1 is equal to zero to determine if it's a whole number
                return arr_nums.Average() % 1 == 0;
            }
        }

        //Write a C# Sharp program to convert the letters of a given string (same case-upper/lower) into alphabetical order
        static void Exercise22()
        {
            // Display original strings and convert letters into alphabetical order
            Console.WriteLine("Original string: PHP");
            Console.WriteLine("Convert the letters of the said string into alphabetical order: " + test("PHP"));

            Console.WriteLine("Original string: javascript");
            Console.WriteLine("Convert the letters of the said string into alphabetical order: " + test("javascript"));

            Console.WriteLine("Original string: python");
            Console.WriteLine("Convert the letters of the said string into alphabetical order: " + test("python"));

            string test(string str1)
            {
                // Using LINQ's OrderBy method to sort characters in the string alphabetically
                // Converting the sorted characters back to a string using new string() and ToArray()
                return new string(str1.OrderBy(x => x).ToArray());
            }
        }

        //Write a C# Sharp program to convert all the values of a given array of mixed values to string values.
        static void Exercise23()
        {
            object[] mixedArr = new object[5];
            mixedArr[0] = 1;
            mixedArr[1] = "Anna";
            mixedArr[2] = false;
            mixedArr[3] = System.DateTime.Now;
            mixedArr[4] = 144.2;

            Console.WriteLine("Printing original array elements and their types:");
            for (int i = 0; i < mixedArr.Length; i++)
            {
                Console.WriteLine("Value-> " + mixedArr[i] + " :: Type-> " + mixedArr[i].GetType());
            }

            string[] newArr = Array.ConvertAll(mixedArr, s => s.ToString());

            Console.WriteLine("\nPrinting original array elements and their types:");
            for (int i = 0; i < newArr.Length; i++)
            {
                Console.WriteLine("Value-> " + newArr[i] + " :: Type-> " + newArr[i].GetType());
            }
        }

        //Write a C# Sharp program to remove all non-letter characters from a given string.
        static void Exercise24()
        {
            string text;

            text = "Py@th12on";
            Console.WriteLine("Orginal string: " + text);
            Console.WriteLine("Remove all characters from the said string which are non-letters: " + test(text));

            // String containing letters, numbers, and spaces
            text = "Python 3.0";
            Console.WriteLine("\nOrginal string: " + text);
            Console.WriteLine("Remove all characters from the said string which are non-letters: " + test(text));

            // String containing letters, numbers, and special characters
            text = "2^sdfds*^*^jlljdslfnoswje34u230sdfds984";
            Console.WriteLine("\nOrginal string: " + text);
            Console.WriteLine("Remove all characters from the said string which are non-letters: " + test(text));

            string test(string text)
            {
                // Using Regex.Replace to remove characters that are not letters (a-zA-Z)
                return Regex.Replace(text, @"[^a-zA-Z]", "");
            }

        }

        //A given string contains the bracket characters '(', ')', '{', '}', '<', ‘>', '[' and ']',
        //Write a C# programme to check the said string is valid or not. The input string will be valid when open brackets and closed brackets are same type of brackets.
        //Or
        //open brackets will be closed in proper order.
        static void Exercise25()
        {
            string text = "";
            Console.WriteLine("Original string: " + text);
            Console.WriteLine("Verify the said string contains valid parentheses: " + test(text));

            text = "<>()[]{}";
            Console.WriteLine("Original string: " + text);
            Console.WriteLine("Verify the said string contains valid parentheses: " + test(text));

            text = "(<>";
            Console.WriteLine("Original string: " + text);
            Console.WriteLine("Verify the said string contains valid parentheses: " + test(text));

            text = "[<>()[]{}]";
            Console.WriteLine("Original string: " + text);
            Console.WriteLine("Verify the said string contains valid parentheses: " + test(text));

            bool test(string s)
            {
                // Creating a stack to store opening parentheses
                Stack<char> ch = new Stack<char>();

                if(s.Length == 0)
                {
                    return false;
                }

                // Iterating through each character in the input string
                foreach (var item in s.ToCharArray())
                {
                    // Checking the type of parentheses and pushing the respective closing parentheses onto the stack
                    if (item == '(')
                        ch.Push(')');
                    else if (item == '<')
                        ch.Push('>');
                    else if (item == '[')
                        ch.Push(']');
                    else if (item == '{')
                        ch.Push('}');
                    else if (ch.Count == 0 || ch.Pop() != item)
                        return false; // If the closing parentheses don't match the top of the stack or stack is empty, return false
                }

                // If the stack is empty after processing all characters, return true, otherwise return false
                return ch.Count == 0;
            }
        }

        //Write a C# Sharp program to sort characters in a given string (uppercase/lowercase letters and numbers). Return the newly sorted string
        static void Exercise26()
        {
            string text = "AaAbfed231";
            Console.WriteLine("Original string: " + text);
            Console.WriteLine("Sorted string: " + test(text));

            text = " ";
            Console.WriteLine("Original string: " + text);
            Console.WriteLine("Sorted string: " + test(text));

            text = "Python";
            Console.WriteLine("Original string: " + text);
            Console.WriteLine("Sorted string: " + test(text));

            text = "W3resource";
            Console.WriteLine("Original string: " + text);
            Console.WriteLine("Sorted string: " + test(text));

            string test(string text)
            {
                if (string.IsNullOrWhiteSpace(text))
                {
                    return "Blank string!";
                }

                var text_nums = text.Where(char.IsDigit).OrderBy(el => el).ToList();
                var text_chars = text.Where(char.IsLetter)
                    .Select(el => new {lchars = char.ToLower(el), chars = el})
                    .OrderBy(el => el.lchars)
                    .ThenByDescending(el => el.chars)
                    //.ThenBy(el => el.chars)
                    .ToList();
                return new string(text_chars.Select(el => el.chars).Concat(text_nums).ToArray());
            }
        }

    }
}
