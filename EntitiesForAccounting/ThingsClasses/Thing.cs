using HW1.AnimalsClasses;
using HW1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1.ThingsClasses
{
    internal class Thing : IThing
    {
        public int Number { get; set; }

        public Thing(int number = 0)
        {
            Number = number;
        }

        public override string ToString()
        {
            return String.Format("Вид: {0}; Номер: {1}\n", typeof(Thing).Name, Number);
        }
    }
}
