using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment35
{
    public class MulticastDelegateExample : MonoBehaviour
    {
        delegate void MathOperation(int number);

        // Start is called before the first frame update
        void Start()
        {
            MathOperation operation;

            operation = DoubleNumber;
            operation += SquareNumber;
            operation += CubeNumber;

            operation(5);
        }

        // Update is called once per frame
        void Update()
        {

        }

        void DoubleNumber(int number) => Debug.Log($"Double: {number * 2}");

        void SquareNumber(int number) => Debug.Log($"Square: {number * number}");

        void CubeNumber(int number) => Debug.Log($"Qube: {number * number * number}");
    }
}