using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1.AnimalsClasses
{
    internal class Predator : Animal
    {
        public Predator(int food, int number = 0) : base(food, number) { }

        public override string ToString()
        {
            return String.Format("Вид: {0}; Еда: {1}; Номер: {2}\n", typeof(Predator).Name, Food, Number);
        }
    }
}
