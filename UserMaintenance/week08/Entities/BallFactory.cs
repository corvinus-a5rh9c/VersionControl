using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserMaintenance.Abstractions;

namespace week08.Entities
{
    public class BallFactory : Abstractions.IToyFactory
    {
        Toy Abstractions.IToyFactory.CreateNew()
        {
            return new Ball();
        }
    }
}
