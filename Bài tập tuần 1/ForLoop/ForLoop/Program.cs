using System.ComponentModel;

namespace ForLoop
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
            Console.ReadLine();
        }

        //Write a C# Sharp program to display an alphabet pattern like D with an asterisk.
        static void Exercise1()
        {
            int row, column;  // Declaration of integer variables for rows and columns

            // Display a message about the pattern being created
            Console.Write("\n\n");
            Console.Write("Display the pattern like 'D' with an asterisk:\n");
            Console.Write("---------------------------------------------");
            Console.Write("\n\n");

            // Loop for iterating through rows
            for (row = 0; row <= 6; row++)
            {
                // Loop for iterating through columns
                for (column = 0; column <= 6; column++)
                {
                    // Check conditions to print '*' or ' ' for specific positions
                    if (column == 1 ||
                        ((row == 0 || row == 6) && (column > 1 && column < 5)) ||
                        (column == 5 && (row != 0 && row != 6)))
                    {
                        Console.Write("*");  // Print '*' for specific conditions
                    }
                    else
                    {
                        Console.Write(" ");  // Print ' ' for other positions
                    }
                }
                Console.Write("\n");  // Move to the next line after each row is printed
            }

            Console.Write("\n");
        }

        //Write a C# Sharp program to display an alphabet pattern like A with an asterisk.
        static void Exercise2()
        {
            int row, column;  // Declaration of integer variables for rows and columns

            // Display a message about the pattern being created
            Console.Write("\n\n");
            Console.Write("Display the pattern like 'A' with an asterisk:\n");
            Console.Write("---------------------------------------------");
            Console.Write("\n\n");

            // Loop for iterating through rows
            for (row = 0; row <= 7; row++)
            {
                // Loop for iterating through columns
                for (column = 0; column <= 7; column++)
                {
                    // Check conditions to print '*' or ' ' for specific positions
                    if (((column == 1 || column == 5) && row != 0) ||
                        ((row == 0 || row == 3) && (column > 1 && column < 5)))
                    {
                        Console.Write("*");  // Print '*' for specific conditions
                    }
                    else
                    {
                        Console.Write(" ");  // Print ' ' for other positions
                    }
                }
                Console.Write("\n");  // Move to the next line after each row is printed
            }

            Console.Write("\n");
        }

        //Write a C# Sharp program to display an alphabet pattern like M with an asterisk.
        static void Exercise3()
        {
            int row, column;  // Declaring variables for rows and columns

            // Display a message about the pattern being created
            Console.Write("\n\n");
            Console.Write("Display the pattern like 'N' with an asterisk:\n");
            Console.Write("---------------------------------------------");
            Console.Write("\n\n");

            // Loop for iterating through rows
            for (row = 0; row <= 6; row++)
            {
                // Loop for iterating through columns
                for (column = 0; column <= 6; column++)
                {
                    // Check conditions to print '*' or ' ' for specific positions
                    if (column == 1 || column == 5 || (row == column && column != 0 && column != 6))
                    {
                        Console.Write("*");  // Print '*' for specific conditions
                    }
                    else
                    {
                        Console.Write(" ");  // Print ' ' for other positions
                    }
                }
                Console.Write("\n");  // Move to the next line after each row is printed
            }

            Console.Write("\n");
        }

        //Write a C# Sharp program to display an alphabet pattern like G with an asterisk.
        static void Exercise4()
        {
            int row, column;  // Declaration of integer variables for rows and columns

            // Display a message about the pattern being created
            Console.Write("\n\n");
            Console.Write("Display the pattern like 'G' with an asterisk:\n");
            Console.Write("---------------------------------------------");
            Console.Write("\n\n");

            // Loop for iterating through rows
            for (row = 0; row <= 6; row++)
            {
                // Loop for iterating through columns
                for (column = 0; column <= 6; column++)
                {
                    // Check conditions to print '*' or ' ' for specific positions
                    if ((column == 1 && row != 0 && row != 6) ||
                        ((row == 0 || row == 6) && column > 1 && column < 5) ||
                        (row == 3 && column > 2 && column < 6) ||
                        (column == 5 && row != 0 && row != 2 && row != 6))
                    {
                        Console.Write("*");  // Print '*' for specific conditions
                    }
                    else
                    {
                        Console.Write(" ");  // Print ' ' for other positions
                    }
                }
                Console.Write("\n");  // Move to the next line after each row is printed
            }

            Console.Write("\n");
        }

        //Write a C# Sharp program to display an alphabet pattern like Q with an asterisk
        static void Exercise5()
        {
            int row, column;  // Declaring variables for rows and columns

            // Display a message about the pattern being created
            Console.Write("\n\n");
            Console.Write("Display the pattern like 'Q' with an asterisk:\n");
            Console.Write("---------------------------------------------");
            Console.Write("\n\n");

            // Loop for iterating through rows
            for (row = 0; row <= 6; row++)
            {
                // Loop for iterating through columns
                for (column = 0; column <= 6; column++)
                {
                    // Check conditions to print '*' or ' ' for specific positions
                    if ((column == 1 && row != 0 && row != 6) ||
                        (row == 0 && column > 1 && column < 5) ||
                        (column == 5 && row != 0 && row != 5) ||
                        (row == 6 && column > 1 && column < 4) ||
                        (column == row - 1 && row > 3))
                    {
                        Console.Write("*");  // Print '*' for specific conditions
                    }
                    else
                    {
                        Console.Write(" ");  // Print ' ' for other positions
                    }
                }
                Console.Write("\n");  // Move to the next line after each row is printed
            }

            Console.Write("\n");
        }

        //Write a C# Sharp program to display an alphabet pattern like U with an asterisk.
        static void Exercise6() {
            int row, column;  // Declaring variables for rows and columns

            // Display a message about the pattern being created
            Console.Write("\n\n");
            Console.Write("Display the pattern like 'U' with an asterisk:\n");
            Console.Write("---------------------------------------------");
            Console.Write("\n\n");

            // Loop for iterating through rows
            for (row = 0; row <= 6; row++)
            {
                // Loop for iterating through columns
                for (column = 0; column <= 6; column++)
                {
                    // Conditions to determine whether to print '*' or ' ' for specific positions
                    if (((column == 1 || column == 5) && row != 6) || (row == 6 && column > 1 && column < 5))
                    {
                        Console.Write("*");  // Print '*' for specific conditions
                    }
                    else
                    {
                        Console.Write(" ");  // Print ' ' for other positions
                    }
                }
                Console.Write("\n");  // Move to the next line after each row is printed
            }

            Console.Write("\n");        
        }

        //Write a C# Sharp program to display an alphabet pattern like Y with an asterisk.
        static void Exercise7()
        {
            int row, column;  // Declaring variables for rows and columns

            // Display a message about the pattern being created
            Console.Write("\n\n");
            Console.Write("Display the pattern like 'Y' with an asterisk:\n");
            Console.Write("---------------------------------------------");
            Console.Write("\n\n");

            // Loop for iterating through rows
            for (row = 0; row <= 6; row++)
            {
                // Loop for iterating through columns
                for (column = 0; column <= 6; column++)
                {
                    // Conditions to determine whether to print '*' or ' ' for specific positions
                    if (((column == 1 || column == 5) && row < 2) || row == column && column > 0 && column < 4 || (column == 4 && row == 2) || ((column == 3) && row > 3))
                    {
                        Console.Write("*");  // Print '*' for specific conditions
                    }
                    else
                    {
                        Console.Write(" ");  // Print ' ' for other positions
                    }
                }
                Console.Write("\n");  // Move to the next line after each row is printed
            }

            Console.Write("\n");
        }

        //Write a C# Sharp program to display an alphabet pattern like E with an asterisk.
        static void Exercise8()
        {
            int row, column;  // Declaration of integer variables for rows and columns

            // Display a message about the pattern being created
            Console.Write("\n\n");
            Console.Write("Display the pattern like 'E' with an asterisk:\n");
            Console.Write("---------------------------------------------");
            Console.Write("\n\n");

            // Loop for iterating through rows
            for (row = 0; row <= 6; row++)
            {
                // Loop for iterating through columns
                for (column = 0; column <= 6; column++)
                {
                    // Check conditions to print '*' or ' ' for specific positions
                    if (column == 1 ||
                        ((row == 0 || row == 6) && (column > 1 && column < 6)) ||
                        (row == 3 && column > 1 && column < 5))
                    {
                        Console.Write("*");  // Print '*' for specific conditions
                    }
                    else
                    {
                        Console.Write(" ");  // Print ' ' for other positions
                    }
                }
                Console.Write("\n");  // Move to the next line after each row is printed
            }

            Console.Write("\n");
        }
    }
}
