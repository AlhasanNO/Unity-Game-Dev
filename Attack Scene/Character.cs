using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment16
{
    public struct Position
    {
        public float x;
        public float y;
        public float z;

        public Position(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public void PrintPosition()
        {
            Debug.Log($"X: {x} Y: {y} Z: {z}");
        }
    }
    public class Character
    {
        public string name;
        private int health;
        protected Position position;

        public int Health
        {
            get => health;
            set => Mathf.Clamp(value, 0, 100);
        }

        public Character()
        {
            name = "No Name";
            health = 100;
            new Position(0, 0, 0);
        }
        public Character(string name, int health, Position position)
        {
            this.name = name;
            Health = health;
            this.position = position;
        }

        public virtual void DisplayInfo()
        {
            Debug.Log(name);
            Debug.Log(health);
            position.PrintPosition();
        }

        public void Attack(int damage, Character target)
        {
            target.health -= damage;
        }

        public void Attack(int damage, Character target, string attackType)
        {
            Attack(damage, target);
            Debug.Log(attackType);
        }
    }
}
