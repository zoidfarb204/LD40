using UnityEngine;
using Assets.Enums;
using System.Collections.Generic;
using Assets.Interfaces;
using Assets.Minerals;
using Assets.People;
using Assets.Player;
using UnityEngine.UI;

public class TimeProcessor : MonoBehaviour
{
    private Person person;
   

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
                Lead.Instance.AddToCirculation(Lead.Instance.NextWeight.Weight);
                Player.Instance.AddMineral(MineralType.Lead, Lead.Instance.NextWeight.Weight);
                Lead.Instance.Timer = 0f;
                Lead.Instance.Weighing = false;
            }
        }
        if (Aluminum.Instance.Weighing)
        {
            Aluminum.Instance.Timer += Time.deltaTime;
            if (Aluminum.Instance.Timer > Aluminum.Instance.WaitTime)
            {
                Aluminum.Instance.AddToCirculation(Aluminum.Instance.NextWeight.Weight);
                Player.Instance.AddMineral(MineralType.Aluminum, Aluminum.Instance.NextWeight.Weight);
                Aluminum.Instance.Timer = 0f;
                Aluminum.Instance.Weighing = false;
            }
        }
        if (person == null)
        {
            person = Person.RemovePerson();
            GameObject.Find("Card").GetComponentInChildren<Text>().text = person != null ? person.Weight.ToString() : "No Person";
        }
    }

    public void Weigh(int typeInt)
    {
        if (person != null)
        {
            MineralType type = (MineralType) typeInt;
            switch (type)
            {
                case MineralType.Lead:
                    if (Lead.Instance.Weighing)
                    {
                        break;
                    }
                    Lead.Instance.Weighing = true;
                    Lead.Instance.NextWeight = person;
                    person = null;
                    break;
                case MineralType.Aluminum:
                    if (Aluminum.Instance.Weighing)
                    {
                        break;
                    }
                    Aluminum.Instance.Weighing = true;
                    Aluminum.Instance.NextWeight = person;
                    person = null;
                    break;
            }
        }
    }
}
