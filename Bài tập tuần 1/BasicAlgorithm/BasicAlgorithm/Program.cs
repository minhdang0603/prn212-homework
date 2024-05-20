using System.ComponentModel;
using System;

namespace BasicAlgorithm {
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
            Exercise11();
            Console.ReadLine();
        }

        //Write a C# Sharp program to remove the character at a given position in the string. The given position will be in the range 0..(string length -1) inclusive.
        static void Exercise1()
        {
            Console.WriteLine(test("Python", 1));  
            Console.WriteLine(test("Python", 0));  
            Console.WriteLine(test("Python", 4));  
            
            string test(string str, int num)
            {
                return str.Remove(num, 1);
            }
        }

        //Write a C# Sharp program to exchange the first and last characters in a given string and return the new string.
        static void Exercise2()
        {
            Console.WriteLine(test("abcd"));  
            Console.WriteLine(test("a"));    
            Console.WriteLine(test("xy"));
            string test(string str)
            {
                if(str.Length > 1)
                {
                    return str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1);
                }

                return str;
            }
        }

        //Write a C# Sharp program to check if a given string contains between 2 and 4 'z' characters.
        static void Exercise3()
        {
            Console.WriteLine(test("frizz")); 
            Console.WriteLine(test("zane"));  
            Console.WriteLine(test("Zazz")); 
            Console.WriteLine(test("false")); 
            Console.WriteLine(test("zzzz"));  
            Console.WriteLine(test("ZZZZ"));  

            bool test(string str)
            {
                return str.Count(s => s.Equals('z')) >= 2 && str.Count(s => s.Equals('z')) <= 4;
            }
        }

        //Write a C# Sharp program to convert the last 3 characters of a given string to uppercase. If the length of the string is less than 3, then uppercase all the characters.
        static void Exercise4()
        {

            Console.WriteLine(test("Python"));
            Console.WriteLine(test("Javascript"));
            Console.WriteLine(test("js"));
            Console.WriteLine(test("PHP"));

            string test(string str)
            {
                return str.Length <= 3 ? str.ToUpper() : str.Remove(str.Length - 3) + str.Substring(str.Length - 3).ToUpper();
            }
        }

        //Write a C# Sharp program to create a string like 'aababcabcd' from a given string 'abcd'.
        static void Exercise5()
        {
            Console.WriteLine(test("abcd"));
            Console.WriteLine(test("abc"));  
            Console.WriteLine(test("a"));

            string test(string str)
            {
                string result = "";

                for (int i = 0; i < str.Length; i++)
                {
                    result += str.Substring(0, i + 1);
                }

                return result;
            }

        }

        //Write a C# Sharp program to check whether one of the first 4 elements in an array of integers is equal to a given element.
        static void Exercise6()
        {
            Console.WriteLine(test(new[] { 1, 2, 9, 3 }, 3));    
            Console.WriteLine(test(new[] { 1, 2, 3, 4, 5, 6 }, 2));
            Console.WriteLine(test(new[] { 1, 2, 2, 3, 9 }, 9));

            bool test(int[] nums, int n)
            {
                return nums.Length < 4 ? nums.Contains(n) : nums.Take(4).Contains(n);
            }
        }

        //Write a C# Sharp program to compare two given strings and return the number of positions where they contain the same length of 2 substrings
        static void Exercise7()
        {

            Console.WriteLine(test("abcdefgh", "abijsklm")); 
            Console.WriteLine(test("abcde", "osuefrcd"));   
            Console.WriteLine(test("pqrstuvwx", "pqkdiewx"));

            int test(string str1, string str2)
            {
                var cnt = 0;

                for (int i = 0; i < str1.Length - 1; i++)
                {
                    var firstString = str1.Substring(i, 2);

                    for (int j = 0; j < str2.Length - 1; j++)
                    {
                        var secondString = str2.Substring(j, 2);

                        if (firstString.Equals(secondString))
                        {
                            cnt++;
                        }
                    }
                }

                return cnt;
            }
        }

        //Write a C# Sharp program to find the largest of two given integers. 
        //However if the two integers have the same remainder when divided by 7, then return the smallest integer. If the two integers are the same, return 0.
        static void Exercise8()
        {
            Console.WriteLine(test(11, 21)); 
            Console.WriteLine(test(11, 20)); 
            Console.WriteLine(test(24, 10)); 
            Console.WriteLine(test(10, 10));
            int test(int num1, int num2)
            {
                if (num1 == num2)
                    return 0;
                if(num1 % 7 == num2 % 7)
                    return num1 < num2 ? num1 : num2;
                else
                    return num1 > num2 ? num1 : num2;
            }
        }


        //Write a C# Sharp program to create a list from a given list of integers, removing all values ending in 7.
        static void Exercise9()
        {

            List<int> mylist = test(new List<int>(new int[] { 10, 22, 35, 47, 53, 67, 88 }));

            // Displaying elements of 'mylist' in the console
            foreach (var i in mylist)
            {
                Console.Write(i.ToString() + " ");
            }

            List<int> test(List<int> nums)
            {
                return nums.Where(n => n % 10 != 7).ToList();
            }
        }

        //Write a C# Sharp program to create a list from a given list of integers removing those values less than 4.
        static void Exercise10()
        {

            List<int> mylist = test(new List<int>(new int[] { 0, -2, 1, 2, 3, 5, 4, 7, 8 }));

            // Displaying elements of 'mylist' in the console
            foreach (var i in mylist)
            {
                Console.Write(i.ToString() + " ");
            }

            List<int> test(List<int> nums)
            {
                return nums.Where(n => n > 4).ToList();
            }
        }

        //Write a C# Sharp program to remove all "a" from each string in a given list of strings and return the result string.
        static void Exercise11()
        {
            List<string> mylist = test(new List<string>(new string[] { "abc", "cdaef", "js", "php" }));

            foreach (var i in mylist)
            {
                Console.Write(i.ToString() + " ");
            }
            List<string> test(List<string> str)
            {
                return str.Select(x => x.Replace("a", "")).ToList();
            }
        }

    }
}