using Assets.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Constants;

namespace Assets.Minerals
{
    public class Aluminum : ResourceBase<Aluminum>
    {
        public override double InitialValue { get { return MineralConstants.ALUMINUM_START_VALUE; } }

        public override double CurrentValue { get { return ResourceMultiplier * PoundsInCirculation + InitialValue; } }

        public override double PoundsInCirculation { get; set; }

        public override double ResourceMultiplier { get { return MineralConstants.ALUMINUM_MULTIPLIER; } }

        public override string ResourceName { get { return "Aluminum"; } }

        public override float WaitTime { get { return 10f; } }
    }
}
