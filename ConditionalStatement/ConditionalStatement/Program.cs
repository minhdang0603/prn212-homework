using System.ComponentModel;

namespace ConditionalStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise1();
            Exercise2();
            Console.ReadLine();
        }

        //Write a program in C# Sharp which is a menu-driven program to perform simple calculations.
        static void Exercise1()
        {
            int num1, num2, opt;  // Declaration of variables to store integers and user's choice

            Console.Write("\n\n");  // Displaying new lines
            Console.Write("A menu driven program for a simple calculator:\n");  // Displaying the purpose of the program
            Console.Write("------------------------------------------------");  // Displaying a separator
            Console.Write("\n\n");

            Console.Write("Enter the first Integer :");  // Prompting the user to enter the first integer
            num1 = Convert.ToInt32(Console.ReadLine());  // Reading the first integer from user input
            Console.Write("Enter the second Integer :");  // Prompting the user to enter the second integer
            num2 = Convert.ToInt32(Console.ReadLine());  // Reading the second integer from user input

            Console.Write("\nHere are the options :\n");  // Displaying available calculation options
            Console.Write("1-Addition.\n2-Subtraction.\n3-Multiplication.\n4-Division.\n5-Exit.\n");
            Console.Write("\nInput your choice :");  // Prompting the user to input their choice
            opt = Convert.ToInt32(Console.ReadLine());  // Reading the user's choice

            switch (opt)  // Switch statement based on the user's choice
            {
                case 1:  // Addition
                    Console.Write("The Addition of {0} and {1} is: {2}\n", num1, num2, num1 + num2);
                    break;
                case 2:  // Subtraction
                    Console.Write("The Subtraction of {0} and {1} is: {2}\n", num1, num2, num1 - num2);
                    break;
                case 3:  // Multiplication
                    Console.Write("The Multiplication of {0} and {1} is: {2}\n", num1, num2, num1 * num2);
                    break;
                case 4:  // Division
                    if (num2 == 0)  // Checking if division by zero
                    {
                        Console.Write("The second integer is zero. Divide by zero.\n");
                    }
                    else
                    {
                        Console.Write("The Division of {0} and {1} is : {2}\n", num1, num2, num1 / num2);
                    }
                    break;
                case 5:  // Exit
                    break;
                default:  // Handling incorrect option
                    Console.Write("Input correct option\n");
                    break;
            }
        }

        //Write C# Sharp program to read any Month Number in integer and display Month name.
        static void Exercise2()
        {
            int monno;  // Declaration of a variable to store the month number

            Console.Write("\n\n");  // Displaying new lines
            Console.Write("Read month number and display month name:\n");  // Displaying the purpose of the program
            Console.Write("-------------------------------------------");  // Displaying a separator
            Console.Write("\n\n");

            Console.Write("Input Month No : ");  // Prompting user to input a month number
            monno = Convert.ToInt32(Console.ReadLine());  // Reading the input and converting it to an integer

            switch (monno)  // Switch statement based on the entered month number
            {
                case 1:
                    Console.Write("January\n");  // Displaying "January" for month number 1
                    break;
                case 2:
                    Console.Write("February\n");  // Displaying "February" for month number 2
                    break;
                case 3:
                    Console.Write("March\n");  // Displaying "March" for month number 3
                    break;
                case 4:
                    Console.Write("April\n");  // Displaying "April" for month number 4
                    break;
                case 5:
                    Console.Write("May\n");  // Displaying "May" for month number 5
                    break;
                case 6:
                    Console.Write("June\n");  // Displaying "June" for month number 6
                    break;
                case 7:
                    Console.Write("July\n");  // Displaying "July" for month number 7
                    break;
                case 8:
                    Console.Write("August\n");  // Displaying "August" for month number 8
                    break;
                case 9:
                    Console.Write("September\n");  // Displaying "September" for month number 9
                    break;
                case 10:
                    Console.Write("October\n");  // Displaying "October" for month number 10
                    break;
                case 11:
                    Console.Write("November\n");  // Displaying "November" for month number 11
                    break;
                case 12:
                    Console.Write("December\n");  // Displaying "December" for month number 12
                    break;
                default:
                    Console.Write("Invalid Month number. \nPlease try again ....\n");  // Handling invalid month numbers
                    break;
            }
        
        }

        //Write a C# Sharp program to calculate profit and loss on a transaction.
        static void Exercise3()
        {
            int cprice, sprice, plamt;  // Declaration of variables to store cost price, selling price, and profit/loss amount

            Console.Write("\n\n");  // Printing new lines
            Console.Write("Calculate profit and loss:\n");  // Displaying the purpose of the program
            Console.Write("----------------------------");  // Displaying a separator
            Console.Write("\n\n");

            Console.Write("Input Cost Price: ");  // Prompting user to input the cost price
            cprice = Convert.ToInt32(Console.ReadLine());  // Reading the input and converting it to an integer
            Console.Write("Input Selling Price: ");  // Prompting user to input the selling price
            sprice = Convert.ToInt32(Console.ReadLine());  // Reading the input and converting it to an integer

            if (sprice > cprice)  // Checking if selling price is greater than cost price
            {
                plamt = sprice - cprice;  // Calculating profit amount
                Console.Write("\nYou can book your profit amount : {0}\n", plamt);  // Printing the profit amount
            }
            else if (cprice > sprice)  // Checking if cost price is greater than selling price
            {
                plamt = cprice - sprice;  // Calculating loss amount
                Console.Write("\nYou got a loss of amount : {0}\n", plamt);  // Printing the loss amount
            }
            else  // Handling scenario where cost price equals selling price
            {
                Console.Write("\nYou are running in no profit no loss condition.\n");  // Printing a message for no profit and no loss
            }
        }
    }
}
