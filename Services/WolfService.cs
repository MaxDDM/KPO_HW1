using HW1.AnimalsClasses;
using HW1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1.Services
{
    internal class WolfService : AnimalService, IService
    {
        public WolfService()
        {
            ServiceType = typeof(Wolf);
        }

        bool IService.CheckHealth(IAnimal animal) { return false; }
    }
}
