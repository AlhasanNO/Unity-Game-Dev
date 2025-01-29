using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{
    public class TestScriptP2 : MonoBehaviour
    {
        CustomObject customObject1 = new(1, "Subhi");
        CustomObject customObject2 = new(2, "Fathi");

        // Start is called before the first frame update
        void Start()
        {
            print(customObject1);
            print(customObject1 == customObject2);
            print(customObject1 != customObject2);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}