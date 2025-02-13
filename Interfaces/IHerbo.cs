using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1.Interfaces
{
    public interface IHerbo : IAnimal
    {
        int KindnessLevel { get; }
    }
}
