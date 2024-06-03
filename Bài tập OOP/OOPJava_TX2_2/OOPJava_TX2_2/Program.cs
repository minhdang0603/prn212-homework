using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace OOPJava_TX2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // mang dong quan ly Employee
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { Name = "John Doe", Address = "US", Salary = 100 },
                new Employee() { Name = "Jane Smith", Address = "UK", Salary = 101 }
            };
            
            // mang dong quan ly Customer
            List<Customer> customers = new List<Customer>()
            {
                new Customer() { Name = "Alice Brown", Address = "Australia", Balance = 100 },
                new Customer() { Name = "Bob Johnson", Address = "Australia", Balance = 50 },
            };

            Console.WriteLine("<---------------Menu--------------->");
            Console.WriteLine("a. Tim nhan vien co luong cao nhat va khach hang co so du nho nhat");
            Console.WriteLine("b. Tim nhan vien theo ten");
            Console.WriteLine("c. Exit");

            while (true)
            {
                try
                {
                    Console.Write("Nhap lua chon: ");
                    char choice = char.Parse(Console.ReadLine());
                    if (choice < 'a' || choice > 'c')
                    {
                        throw new OutOfRangeException("Your input out of range!");
                    }
                    switch (choice)
                    {
                        case 'a':
                            getEmployeeAndCustomer(employees, customers);
                            break;
                        case 'b':
                            Console.Write("Nhap ten: ");
                            string name = Console.ReadLine();
                            Employee[] e2 = getByName(employees, name);
                            if (e2 == null || e2.Length == 0)
                            {
                                Console.WriteLine("Nhan vien khong ton tai");
                            }
                            else
                            {
                                foreach(Employee e in e2)
                                {
                                    e.display();
                                }
                            }
                            break;
                        default:
                            break;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (OutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (NoNullAllowedException e)
                {
                    Console.WriteLine(e.Message);
                }
            } // end while

        } // end main

        static void getEmployeeAndCustomer(List<Employee> employees, List<Customer> customers)
        {
            // get employee have highest salary
            var employee = employees.OrderByDescending(e => e.Salary).FirstOrDefault();

            // get customer have lowest balance
            var customer = customers.OrderBy(c => c.Balance).FirstOrDefault();

            Console.Write("Nhan vien co luong cao nhat la: ");
            employee.display();
            Console.Write("Khach hang co so du thap nhat la: ");
            customer.display();
        } // end getEmployeeAndCustomer

        static Employee[] getByName(List<Employee> list, string name)
        {
            // get employee by name
            var employee = list.Where(e => e.Name.Contains(name)).ToArray();
            return employee;
        } // end getByName

    } // end Program

    class OutOfRangeException : Exception
    {
        public OutOfRangeException(string? message) : base(message)
        {
        }
    }
}
