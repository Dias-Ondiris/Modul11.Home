using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul11.Home
{
    internal struct Employee : IEmployee
    { 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public DateTime DateOfEmployment { get; set; }
        public string Gender { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public override string ToString()
        {
            return $"Имя: {FullName}, Должность: {Position}, Зарплата: {Salary}, Дата трудоустройства: {DateOfEmployment.ToShortDateString()}, Пол: {Gender}";
        }
    }
}
