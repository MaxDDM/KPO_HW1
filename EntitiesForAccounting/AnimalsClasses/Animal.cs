using HW1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1.AnimalsClasses
{
    public class Animal : IAnimal
    {
        int _food;
        public int Food { get => _food; }
        public int Number { get; set; }

        public Animal(int food, int number = 0)
        {
            if (food < 1)
            {
                throw new ArgumentOutOfRangeException("Еда не может быть меньше 1");
            }
            _food = food;
            Number = number;
        }
        public override string ToString()
        {
            return String.Format("Вид: {0}; Еда: {1}; Номер: {2}\n", typeof(Animal).Name, Food, Number); 
        }
    }
}
