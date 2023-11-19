using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul11.Home
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите количество сотрудников:");
                int numberOfEmployees = int.Parse(Console.ReadLine());
                Employee[] employees = new Employee[numberOfEmployees];

                for (int i = 0; i < numberOfEmployees; i++)
                {
                    while (true)
                    {
                        try
                        {
                            Console.WriteLine($"Введите данные для сотрудника {i + 1} (Имя, Фамилия, Должность, Зарплата, Дата трудоустройства [гггг-мм-дд], Пол):");
                            var data = Console.ReadLine().Split(',');
                            employees[i] = new Employee
                            {
                                FirstName = data[0],
                                LastName = data[1],
                                Position = data[2],
                                Salary = decimal.Parse(data[3]),
                                DateOfEmployment = DateTime.Parse(data[4]),
                                Gender = data[5]
                            };
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Постарайтесь написать без ошибок");
                        }
                    }
                }

                // a. Full information about all employees
                Console.WriteLine("\nВсе сотрудники:");
                foreach (var employee in employees)
                {
                    Console.WriteLine(employee);
                }
            }
            Console.ReadKey();
        }
    }
}
