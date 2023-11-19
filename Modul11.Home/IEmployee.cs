using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul11.Home
{
    internal interface IEmployee
    {
        string FullName { get; }
        string Position { get; }
        decimal Salary { get; }
        DateTime DateOfEmployment { get; }
        string Gender { get; }
        string ToString();
    }

}
