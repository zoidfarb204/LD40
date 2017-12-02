using System;
using Assets.Interfaces;

namespace Assets.Minerals
{
    public class Lead : ResourceBase<Lead>
    {
        public override double InitialValue { get { return 100; } }

        public override double CurrentValue { get { return ResourceMultiplier * PoundsInCirculation + InitialValue; } }

        public override double PoundsInCirculation { get; set; }

        public override double ResourceMultiplier { get { return -1; } }

        public override string ResourceName { get { return "Lead"; } }

        public override float WaitTime { get { return 5f; } }
    }
}
