using System;
using System.Collections;
using System.Collections.Generic;
using Assets.Enums;
using Assets.Minerals;
using UnityEngine;
using UnityEngine.UI;

public class Progress : MonoBehaviour
{

    public MineralType mineralType;
    Image foregroundImage;

    void Start()
    {
        foregroundImage = gameObject.GetComponent<Image>();
    }

    void Update()
    {
        switch (mineralType)
        {
            case MineralType.Lead:
                foregroundImage.fillAmount = Lead.Instance.Timer / Lead.Instance.WaitTime;
                break;
            case MineralType.Aluminum:
                foregroundImage.fillAmount = Aluminum.Instance.Timer / Aluminum.Instance.WaitTime;
                break;
        }
    }
}
