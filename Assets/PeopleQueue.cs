using System.Collections;
using System.Collections.Generic;
using Assets.People;
using UnityEngine;
using UnityEngine.Networking;

public class PeopleQueue : MonoBehaviour
{
    private float timer = 0;
    private float timeToPerson = 10;

	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update ()
	{
	    if (Person.People == null || Person.People.Count < 5)
	    {
	        timer += Time.deltaTime;
	        if (timer >= timeToPerson)
	        {
	            Person.AddPerson(Random.Range(150, 250));
	            timer = 0;
	        }
	    }
	}
}
