using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment16
{
    public class Soldier : Character
    {
        public Soldier() { }

        public Soldier(string name, int health, Position position) : base(name, health, position) { }

        public override void DisplayInfo()
        {
            Debug.Log("Soldier:");
            base.DisplayInfo();
        }
    }
}