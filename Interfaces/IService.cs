using HW1.AnimalsClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1.Interfaces
{
    public interface IService
    {
        public Type ServiceType { get; set; }

        public bool CheckHealth(IAnimal animal) { return true; }
    }
}
