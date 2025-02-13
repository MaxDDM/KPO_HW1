using HW1.AnimalsClasses;
using HW1.EntitiesForAccounting;
using HW1.ThingsClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1.Interfaces
{
    internal interface IZoo
    {
        private static readonly List<Type> typesOfAnimals = new List<Type>();
        private static readonly List<Type> typesOfThings = new List<Type>();
        private static readonly List<Type> typesOfEmployees = new List<Type>();
        public IClinic? Clinic { get; set; }
        public int Food { get; }

        public void AddAnimal(IAnimal animal) { }

        public List<IHerbo> ContactZooList() => new List<IHerbo>();
    }
}
