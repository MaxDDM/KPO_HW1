using HW1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1.EntitiesForAccounting
{
    internal class Employee : IEmployee
    {
        public override string ToString()
        {
            return "Работник\n";
        }
    }
}
