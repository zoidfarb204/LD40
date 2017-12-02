﻿using Assets.Minerals;
using UnityEngine;
using UnityEngine.UI;


public class GUIController : MonoBehaviour {

    [Range(0, 100)]
    public int AmountLead;

    

    Text LeadText;
    Text AluminumText;

	// Use this for initialization
	void Start () {
        LeadText = GameObject.Find("Lead").GetComponent<Text>();
        AluminumText = GameObject.Find("Aluminum").GetComponent<Text>();


        LeadText.text = Lead.Instance.CurrentValue.ToString();
        AluminumText.text = Aluminum.Instance.CurrentValue.ToString();

    }

    // Update is called once per frame
    void Update () {
        LeadText.text = Lead.Instance.CurrentValue.ToString();
        AluminumText.text = Aluminum.Instance.CurrentValue.ToString();


    }
}