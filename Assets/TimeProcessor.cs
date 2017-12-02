using UnityEngine;
using Assets.Enums;
using System.Collections.Generic;
using Assets.Interfaces;
using Assets.Minerals;

public class TimeProcessor : MonoBehaviour
{


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Lead.Instance.Weighing)
        {
            Lead.Instance.Timer += Time.deltaTime;
            if (Lead.Instance.Timer > Lead.Instance.WaitTime)
            {
                Lead.Instance.AddToCirculation(1);
                Lead.Instance.Timer = 0f;
                Lead.Instance.Weighing = false;
            }
        }
        if (Aluminum.Instance.Weighing)
        {
            Aluminum.Instance.Timer += Time.deltaTime;
            if (Aluminum.Instance.Timer > Aluminum.Instance.WaitTime)
            {
                Aluminum.Instance.AddToCirculation(1);
                Aluminum.Instance.Timer = 0f;
                Aluminum.Instance.Weighing = false;
            }
        }
    }

    public void Weigh(int typeInt)
    {
        MineralType type = (MineralType)typeInt ;
        switch (type)
        {
            case MineralType.Lead:
                Lead.Instance.Weighing = true;
                break;
            case MineralType.Aluminum:
                Aluminum.Instance.Weighing = true;
                break;
        }
    }
}
