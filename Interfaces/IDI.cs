using HW1.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1.Interfaces
{
    public interface IDI
    {
        public IService? GetService(Type animalType) { return null; }
    }
}
