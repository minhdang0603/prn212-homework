using System.ComponentModel;
using System.IO;
using System.Net;

namespace ExceptionHandling{
    class Programm
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
            Exercise8();
        }

        //Write a C# program that prompts the user to input two numbers and divides them. Handle an exception when the user enters non-numeric values.
        static void Exercise1()
        {
            try
            {
                Console.Write("Input the first number: ");
                double first = double.Parse(Console.ReadLine());
                Console.Write("Input the second number: ");
                double second = double.Parse(Console.ReadLine());

                if(second != 0)
                {
                    Console.WriteLine("Result: " + (first / second));
                } else
                {
                    Console.WriteLine("Error: Cannot divide by zero.");
                }
            } catch(FormatException e) 
            {
                Console.WriteLine("Error: Non-numeric value entered.");
            } catch(Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        //Write a C# program to implement a method that takes an integer as input and throws an exception if the number is negative. Handle the exception in the calling code
        static void Exercise2()
        {
            try
            {
                Console.Write("Input an integer: ");
                int first = int.Parse(Console.ReadLine());
                if (first < 0)
                    throw new Exception("Negative number not allowed.");
            } catch(FormatException e)
            {
                Console.WriteLine("Error: Non-numeric value entered.");
            } catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

        }

        //Write a C# program that reads a file path from the user and tries to open the file. Handle exceptions if the file does not exist.
        static void Exercise3()
        {
            var path = Console.ReadLine();
            try
            {
                using(StreamReader reader = new StreamReader(path))
                {
                    Console.WriteLine($"{reader.ReadToEnd()}");
                    Console.WriteLine("File opened successfully.");
                }
            } catch (FileNotFoundException ex)
            {
                Console.WriteLine("Error: File not found.");
            } catch (IOException ex)
            {
                Console.WriteLine("An error occurred while accessing the file: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        //Write a C# program that implements a method that takes an array of integers as input and calculates the average value. Handle the exception if the array is empty.
        static void Exercise4()
        {
            try
            {
                Console.Write("Input the size of the array: ");
                int count = Convert.ToInt32(Console.ReadLine());

                int[] numbers = new int[count];

                for (int i = 0; i < count; i++)
                {
                    Console.Write("Input element-{0}: ", i + 1);
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }

                double average = CalculateAverage(numbers);

                Console.WriteLine("Average: " + average);
            }
            catch (EmptyArrayException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input. Please input integers only.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            double CalculateAverage(int[] numbers)
            {
                if (numbers.Length == 0)
                {
                    throw new EmptyArrayException("Array is empty. Cannot calculate average.");
                }

                int sum = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    sum += numbers[i];
                }

                return (double)sum / numbers.Length;
            }
        }

        //Write a C# program that reads a list of integers from the user. Handle the exception that occurs if the user enters a value outside the range of Int32
        static void Exercise5()
        {
            List<int> numbers = new List<int>();
            try
            {
                Console.WriteLine("Input a list of integers (Input 'exit' to finish):");

                while (true)
                {
                    Console.Write("Input an integer: ");
                    string input = Console.ReadLine();

                    if (input.ToLower() == "exit")
                        break;

                    int number = Convert.ToInt32(input);
                    numbers.Add(number);
                }
            } catch (FormatException)
            {
                // Catch block for handling FormatException when non-integer input is entered
                Console.WriteLine("Error: Invalid input. Please enter a valid integer.");
            } catch (OverflowException)
            {
                // Catch block for handling OverflowException when the entered value is outside the range of Int32
                Console.WriteLine("Error: The value entered is outside the range of Int32.");
            } catch (Exception ex)
            {
                // Catch block for handling other types of exceptions
                Console.WriteLine("An error occurred: " + ex.Message);
            }

        }

        //Write a C# program that creates a method that reads a date from the user in the format "dd/mm/yyyy" and converts it to a DateTime object
        //Handle an exception if the input format is invalid
        static void Exercise6()
        {
            try
            {
                Console.Write("Input a date (format-> dd/mm/yyyy): ");
                string input = Console.ReadLine();
                DateTime date = ConvertToDate(input);
                Console.WriteLine("Date: " + date.ToShortDateString());
            } catch (FormatException)
            {
                Console.WriteLine("Error: Invalid date format. Please input a valid date in the format dd/mm/yyyy.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            DateTime ConvertToDate(string input)
            {
                // Define the date format expected from the user input
                string[] format = { "dd/MM/yyyy" };

                // Parse the input string to a DateTime object using the specified format
                return DateTime.ParseExact(input, format, null, System.Globalization.DateTimeStyles.None);
            }
        }

        //Write a C# program that creates a method that takes a string as input and converts it to uppercase
        //Handle the NullReferenceException that occurs if the input string is null.
        static void Exercise7()
        {
            try
            {
                Console.Write("Input a string: ");
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                    throw new ArgumentException("Input string is null or empty.");
                Console.WriteLine("Uppercase string: " + input.ToUpper());
            } catch (NullReferenceException) {
                Console.WriteLine("Error: Input string is null.");
            } catch(ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            } catch(Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        //Write a C# program that reads a list of URLs from the user and downloads the content of each URL. Handle the exception if any URL is inaccessible.
        static void Exercise8()
        {
            Console.Write("Input the URLs (one URL per line, press Enter to complete): ");
            try
            {
                while (true)
                {
                    string url = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(url))
                    {
                        break;
                    }
                    DownLoadWebContent(url);
                }
            } catch (WebException ex) {
                Console.WriteLine("Error accessing URL: " + ex.Message);
            } catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            void DownLoadWebContent(string url)
            {
                WebClient webClient = new WebClient();

                string content = webClient.DownloadString(url);
                Console.WriteLine("Content of URL '" + url + "':");
                Console.WriteLine(content);
                Console.WriteLine();
            }
        }

    }

    class EmptyArrayException : Exception
    {
        public EmptyArrayException(string message) : base(message) { }
    }

}
