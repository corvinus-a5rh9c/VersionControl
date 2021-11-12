using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserMaintenance.Abstractions;

namespace week08.Abstractions
{
    public interface IToyFactory
    {
        Toy CreateNew();
    }
}
