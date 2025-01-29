using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{
    public class TypeManagementScript : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Animal animal = new Cat();
            animal.MakeSound();
            animal.Move();

            Cat cat = animal as Cat;
            cat.MakeSound();
            cat.Move();

            Warrior warrior = new();
            List<ICanFight> canFights = new() { cat, warrior };

            foreach (var canFight in canFights)
            {
                if (canFight is Cat)
                {
                    Debug.Log("The object is a Cat.");
                }

                if (canFight is Warrior)
                {
                    Debug.Log("The object is a Warrior.");
                }

                canFight.Attack();
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
