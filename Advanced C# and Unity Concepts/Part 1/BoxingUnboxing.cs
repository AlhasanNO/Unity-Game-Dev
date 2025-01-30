using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment35
{
    public class BoxingUnboxing : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            int health = 100;
            object boxing = health;
            int unboxing = (int)boxing;
            unboxing = 20;

            Debug.Log("Original int value: " + health);
            Debug.Log("Boxed value: " + boxing);
            Debug.Log("Unboxed and modified value: " + unboxing);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}