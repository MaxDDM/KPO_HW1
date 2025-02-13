using HW1.AnimalsClasses;
using HW1.Interfaces;
using HW1.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    public class Clinic : IClinic
    {
        private IDI _di;
        public Clinic(IDI di)
        {
            _di = di;
        }
        bool IClinic.CheckHealth(IAnimal animal, Type animalType) 
        {
            IService service = _di.GetService(animalType);
            return service.CheckHealth(animal);
        }
    }
}
