using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using Assets.Enums;

namespace Assets.Player
{
    public class Player
    {
        private static Player _instance;

        public float PercentOfWeight { get { return .20f; } }

        public float Lead { get; private set;}

        public float Aluminum { get; private set; }


        public static Player Instance
        {
            get { return _instance ?? (_instance = new Player()); }
        }

        public void AddMineral(MineralType mineralType, float ammount)
        {
            switch (mineralType)
            {
                case MineralType.Lead:
                    Lead += (ammount * PercentOfWeight);
                    break;
                case MineralType.Aluminum:
                    Aluminum += (ammount * PercentOfWeight);
                    break;
            }
        }
    }
}
