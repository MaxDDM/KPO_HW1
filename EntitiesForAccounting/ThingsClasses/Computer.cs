using HW1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1.ThingsClasses
{
    internal class Computer : Thing, IThing
    {
        public Computer(int number = 0) : base(number) { }

        public override string ToString()
        {
            return String.Format("Вид: {0}; Номер: {1}\n", typeof(Computer).Name, Number);
        }
    }
}
