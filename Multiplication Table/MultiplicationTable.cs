using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplicationTable : MonoBehaviour
{
    // Start is called before the first frame update
    int Multiply(int a, int b)
    {
        return a * b;
    }

    void Start()
    {

        for (int i = 1; i <= 10; i++)
        {
            Debug.Log($"5 x {i} = {Multiply(5, i)}");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
