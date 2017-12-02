using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEditor;

namespace Assets.People
{
    

    public class Person
    {
        public static Queue<Person> People { get;  private set; }

        public int Weight { get; private set; }

        private Person(int weight)
        {
            this.Weight = weight;
        }

        public static void AddPerson(int weight)
        {
            if (People == null)
            {
                People = new Queue<Person>();
            }
            People.Enqueue(new Person(weight));
        }

        public static Person RemovePerson()
        {
            if (People == null || People.Count < 1)
            {
                return null;
            }
            return People.Dequeue();
        }
    }
}
