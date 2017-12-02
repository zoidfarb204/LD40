using System;
using Assets.Constants;
using Assets.Interfaces;

namespace Assets.Minerals
{
    public class Lead : ResourceBase<Lead>
    {
        public override double InitialValue { get { return MineralConstants.LEAD_START_VALUE; } }

        public override double CurrentValue { get { return ResourceMultiplier * PoundsInCirculation + InitialValue; } }

        public override double PoundsInCirculation { get; set; }

        public override double ResourceMultiplier { get { return MineralConstants.LEAD_MULTIPLIER; } }

        public override string ResourceName { get { return "Lead"; } }

        public override float WaitTime { get { return 5f; } }
    }
}
