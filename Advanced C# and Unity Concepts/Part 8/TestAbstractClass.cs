using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment35
{
    public class TestAbstractClass : MonoBehaviour
    {
        DerivedClassExample derivedClassExample = new();

        // Start is called before the first frame update
        void Start()
        {
            derivedClassExample.PerformAction();
            derivedClassExample.PrintInfo();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}