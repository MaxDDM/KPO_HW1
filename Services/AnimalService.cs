using HW1.AnimalsClasses;
using HW1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1.Services
{
    internal class AnimalService : IService
    {
        private Type _serviceType = typeof(Animal);

        public Type ServiceType
        {
            get => _serviceType;
            set
            {
                _serviceType = value;
            }
        }

        bool IService.CheckHealth(IAnimal animal) { return true; }
    }
}
