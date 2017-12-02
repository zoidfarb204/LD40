using Assets.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Minerals
{
    public class Aluminum : ResourceBase<Aluminum>
    {
        public override double InitialValue { get { return 200; } }

        public override double CurrentValue { get { return ResourceMultiplier * PoundsInCirculation + InitialValue; } }

        public override double PoundsInCirculation { get; set; }

        public override double ResourceMultiplier { get { return -.25; } }

        public override string ResourceName { get { return "Aluminum"; } }

        public override float WaitTime { get { return 10f; } }
    }
}
