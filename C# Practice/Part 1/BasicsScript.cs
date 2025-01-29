using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{
    public class BasicsScript : MonoBehaviour
    {

        // Start is called before the first frame update
        void Start()
        {
            var num = 5;
            var name = "Subhi";
            var isTrue = false;

            Debug.Log(num % 2 == 0 ? $"Number {num} is Even" : $"Number {num} is Odd");
            Debug.Log(DateTime.Now.Date);
            Debug.Log(DateTime.Now.TimeOfDay);
            Debug.Log(DateTime.Now.Day);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}