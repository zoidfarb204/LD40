using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Resources
{
    public class Lead : IResource
    {
        public double InitialValue { get { return 100; } }

        public double CurrentValue { get { return ResourceMultiplier * PoundsInCirculation + InitialValue; } }

        public double PoundsInCirculation { get; set; }

        public double ResourceMultiplier { get { return -1; } } 

        public string ResourceName { get { return "Lead"; } }
    }
}
