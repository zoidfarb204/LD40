using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IResource
    {
        string ResourceName { get; }

        double ResourceMultiplier { get;  }

        double InitialValue { get;}

        double CurrentValue { get; }

        double PoundsInCirculation { get; set; }
    }
}
