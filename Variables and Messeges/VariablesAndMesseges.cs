using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndMesseges : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int x = 6;
        string y = "Fathieh";

        Debug.Log(x + 10);
        Debug.Log(y);
        Debug.LogWarning("Tahtheer");
        Debug.LogError("Musibah");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
