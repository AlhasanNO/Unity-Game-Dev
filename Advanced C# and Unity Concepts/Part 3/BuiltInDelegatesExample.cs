using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment35
{
    public class BuiltInDelegatesExample : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            logMessage();
            Debug.Log($"Square: {square(5)}");
            Debug.Log($"Is 4 even? {isEven(4)}");
        }

        // Update is called once per frame
        void Update()
        {

        }

        Action logMessage = () => Debug.Log("Hello from Action delegate!");

        Func<int, int> square = (number) => number * number;

        Predicate<int> isEven = (number) => number % 2 == 0;
    }
}