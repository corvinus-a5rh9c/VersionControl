using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserMaintenance.Abstractions;
using week08.Abstractions;

namespace week08.Entities
{
    public class CarFactory : Abstractions.IToyFactory
    {
        Toy Abstractions.IToyFactory.CreateNew()
        {
            return new Car();
        }
    }
}
