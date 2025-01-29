using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{
    public class TestScriptP3 : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Debug.Log(Utilities.Add(5, 10, 20));
            Debug.Log("Thing".RepeatString(3));
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}