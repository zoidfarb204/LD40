using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Interfaces
{
    public abstract class ResourceBase<T> where T : ResourceBase<T>, new()
    {

        private static T _instance = new T();
        public static T Instance
        {
            get
            {
                return _instance;
            }
        }
        
       public abstract string ResourceName { get; }

        public abstract double ResourceMultiplier { get; }

        public abstract double InitialValue { get; }

        public abstract double CurrentValue { get; }

        public abstract double PoundsInCirculation { get; set; }

        public abstract float WaitTime { get; }

        public virtual float Timer { get; set; }

        public virtual bool Weighing { get; set; }

        public virtual void AddToCirculation(double ammount)
        {
            this.PoundsInCirculation += ammount;
        }
    }
}
