using HW1.AnimalsClasses;
using HW1.EntitiesForAccounting;
using HW1.Interfaces;
using HW1.ThingsClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    public class Zoo : IZoo
    {
        List<(IAnimal, Type)> _animals = new List<(IAnimal, Type)>();
        List<(IThing, Type)> _things = new List<(IThing, Type)>();
        List<(IEmployee, Type)> _employees = new List<(IEmployee, Type)>();

        public IClinic? Clinic { get; set; }

        public int Food {
            get
            {
                int sum = 0;
                for (int i = 0; i < _animals.Count; i++)
                {
                    sum += _animals[i].Item1.Food;
                }
                return sum;
            }
        }

        public bool AddObject<T>(T obj, Type objType)
        {
            switch (obj) 
            {
                case IAnimal animal:
                    if (Clinic == null)
                    {
                        throw new ArgumentNullException("У зоопарка нет клиники, добавить животное невозможно");
                    }
                    if (Clinic.CheckHealth(animal, objType))
                    {
                        animal.Number = _animals.Count();
                        _animals.Add((animal, objType));
                    }
                    else
                    {
                        return false;
                    }
                    break;
                case IThing thing:
                    thing.Number = _things.Count();
                    _things.Add((thing, objType));
                    break;
                case IEmployee employee:
                    _employees.Add((employee, objType));
                    break;
                default:
                    throw new ArgumentException("Объект неподходящего типа");
            }
            return true;
        }

        public bool DeleteObject<T>(int ind)
        {
            switch (typeof(T))
            {
                case Type animalType when animalType == typeof(IAnimal):
                    _animals.RemoveAt(ind);
                    ResetAnimalsId<IAnimal>(ref _animals);
                    break;
                case Type thingType when thingType == typeof(IThing):
                    _things.RemoveAt(ind);
                    ResetAnimalsId<IThing>(ref _things);
                    break;
                case Type employeeType when employeeType == typeof(IEmployee):
                    _employees.RemoveAt(ind);
                    break;
                default:
                    throw new ArgumentException("Передан неподходящий тип");
            }
            return true;
        }

        public List<T> GetInfo<T>()
        {
            List<T> list = new List<T>();
            switch (typeof(T))
            {
                case Type animalType when animalType == typeof(IAnimal):
                    for (int i = 0; i < _animals.Count(); ++i)
                    {
                        list.Add((T)_animals[i].Item1);
                    }
                    break;
                case Type thingType when thingType == typeof(IThing):
                    for (int i = 0; i < _things.Count(); ++i)
                    {
                        list.Add((T)_things[i].Item1);
                    }
                    break;
                case Type employeeType when employeeType == typeof(IEmployee):
                    for (int i = 0; i < _employees.Count(); ++i)
                    {
                        list.Add((T)_employees[i].Item1);
                    }
                    break;
                default:
                    throw new ArgumentException("Передан неподходящий тип");
            }
            return list;
        }
        public List<IAnimal> ContactZooList()
        {
            List<IAnimal> animals = new List<IAnimal>();
            for (int i = 0; i < _animals.Count; ++i)
            {
                if (_animals[i].Item1 is IHerbo herbo && herbo.KindnessLevel > 5)
                {
                    animals.Add(herbo);
                }
            }
            return animals;
        }

        private void ResetAnimalsId<T>(ref List<(T, Type)> list) where T : IInventory
        {
            for (int i = 0; i < list.Count(); ++i)
            {
                list[i].Item1.Number = i;
            }
        }
    }
}
