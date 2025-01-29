using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace Assignment27
{
    public class FunctionCall : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            int a = 5;
            int b = 10;

            AddByValue(a, b);
            Debug.Log(a);

            AddByReference(ref a, b);
            Debug.Log(a);

            ChangeByOut(out a, b);
            Debug.Log(a);
        }

        // Update is called once per frame
        void Update()
        {

        }

        void AddByValue(int a, int b)
        {
            a += b;
        }

        void AddByReference(ref int a, int b)
        {
            a += b;
        }
        void ChangeByOut(out int a, int b)
        {
            a = b;
        }
    }
}
