using HW1.AnimalsClasses;
using HW1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1.Services
{
    internal class RabbitService : AnimalService, IService
    {
        public RabbitService()
        {
            ServiceType = typeof(Rabbit);
        }

        bool IService.CheckHealth(IAnimal animal) { return true; }
    }
}
