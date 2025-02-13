using HW1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace HW1.AnimalsClasses
{
    internal class Herbo : Animal, IHerbo
    {
        public int KindnessLevel { get; }

        public Herbo(int food, int kindnessLevel, int number = 0) : base(food, number) 
        {
            if (kindnessLevel < 0 || kindnessLevel > 10)
            {
                throw new ArgumentOutOfRangeException("Уровень доброты не может быть меньше 0 или больше 10");
            }
            KindnessLevel = kindnessLevel;
        }

        public override string ToString()
        {
            return String.Format("Вид: {0}; Еда: {1}; Номер: {2}, Уровень доброты: {3}\n", typeof(Herbo).Name, Food, Number, KindnessLevel);
        }
    }
}
