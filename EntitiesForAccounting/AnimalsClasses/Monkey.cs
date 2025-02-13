using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1.AnimalsClasses
{
    internal class Monkey : Herbo
    {
        public Monkey(int food, int kindnessLevel, int number = 0) : base(food, kindnessLevel, number) { }

        public override string ToString()
        {
            return String.Format("Вид: {0}; Еда: {1}; Номер: {2}, Уровень доброты: {3}\n", typeof(Monkey).Name, Food, Number, KindnessLevel);
        }
    }
}
