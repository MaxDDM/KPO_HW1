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
    public class DI : IDI
    {
        List<IService> _services = new List<IService>() { new AnimalService(), new MonkeyService(), new RabbitService(), new TigerService(), new WolfService() };
        List<Type> _serviceTypes = new List<Type>() { typeof(AnimalService), typeof(MonkeyService), typeof(RabbitService), typeof(TigerService), typeof(WolfService) };
        ServiceCollection _servicesCollection = new ServiceCollection();
        ServiceProvider _serviceProvider;

        public DI() 
        {
            _servicesCollection.AddSingleton<AnimalService>();
            _servicesCollection.AddSingleton<MonkeyService>();
            _servicesCollection.AddSingleton<RabbitService>();
            _servicesCollection.AddSingleton<TigerService>();
            _servicesCollection.AddSingleton<WolfService>();

            _serviceProvider = _servicesCollection.BuildServiceProvider();
        }

        public IService GetService(Type animalType)
        {
            for (int i = 0; i < _services.Count(); i++)
            {
                if (animalType == _services[i].ServiceType)
                {
                    return (IService)_serviceProvider.GetService(_serviceTypes[i]);
                }
            }
            return (IService)_serviceProvider.GetService(_serviceTypes[0]);
        }
    }
}
