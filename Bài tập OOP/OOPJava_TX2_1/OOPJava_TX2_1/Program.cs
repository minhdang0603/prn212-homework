using System;
using System.Data;

namespace OOPJava_TX2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>()
            {
                new FullTimeEmployee("John", 20),
                new PartTimeEmployee("Doe", 10, 4),
                new FullTimeEmployee("Maria", 25),
                new PartTimeEmployee("Lara", 12, 6),
                new PartTimeEmployee("Harry", 18, 7)
            };

            Console.WriteLine("<---------------Menu--------------->");
            Console.WriteLine("a. Tim nhan vien co luong cao nhat");
            Console.WriteLine("b. Tim nhan vien theo ten");
            Console.WriteLine("c. Nhap ten va luong cua Fulltime Employee");
            Console.WriteLine("d. Exit");

            while (true) {
                try
                {
                    Console.Write("Nhap lua chon: ");
                    char choice = char.Parse(Console.ReadLine());
                    if (choice < 'a' || choice > 'd')
                    {
                        throw new OutOfRangeException("Your input out of range!");
                    }
                    switch (choice)
                    {
                        case 'a': 
                            Employee e = getHighest(list);
                            Console.WriteLine("Nhan vien co luong cao nhat la: " + e.getName());
                            break;
                        case 'b':
                            Console.Write("Nhap ten: ");
                            string name = Console.ReadLine();
                            Employee e2 = getByName(list, name);
                            if(e2 == null)
                            {
                                Console.WriteLine("Nhan vien khong ton tai");
                            }
                            else
                            {
                                Console.WriteLine(e2.ToString());
                            }
                            break;
                        case 'c':
                            Console.Write("Nhap ten: ");
                            string name2 = Console.ReadLine();
                            Console.Write("Nhap luong theo gio: ");
                            double luong = double.Parse(Console.ReadLine());
                            list.Add(new FullTimeEmployee(name2, luong));
                            break;
                        default:
                            break;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                } catch (OutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                } catch(NoNullAllowedException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            
        }

        static Employee getHighest(List<Employee> list)
        {
            // get employee have highest salary
            var employee = list.OrderByDescending(e => e.calculateSalary()).FirstOrDefault();
            return employee;
        }

        static Employee getByName(List<Employee> list, string name)
        {
            // get employee by name
            var employee = list.Where(e => e.getName().Contains(name)).ToArray();
            return employee[0];
        }
    }

    class OutOfRangeException : Exception
    {
        public OutOfRangeException(string? message) : base(message)
        {
        }
    }
}
