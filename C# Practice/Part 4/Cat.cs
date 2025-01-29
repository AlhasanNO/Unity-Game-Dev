using UnityEngine;

namespace Assignment29
{
    public class Cat : Animal, ICanFight
    {
        public void Attack()
        {
            Debug.Log("Cat attacks with claws!");
        }

        public override void MakeSound()
        {
            Debug.Log("Meow!");
        }

        public void Move()
        {
            Debug.Log("Cat runs quickly.");
        }
    }
}