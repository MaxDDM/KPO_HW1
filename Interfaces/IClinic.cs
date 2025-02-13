using HW1.AnimalsClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1.Interfaces
{
    public interface IClinic
    {
        bool CheckHealth(IAnimal animal, Type animalType) { return true; }
    }
}
