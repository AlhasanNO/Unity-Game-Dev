using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecursionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(FibonacciRecursive(10));
        Debug.Log(FibonacciIterative(10));

        Debug.Log(FibonacciRecursive(30));
        Debug.Log(FibonacciIterative(30));
    }

    // Update is called once per frame
    void Update()
    {

    }

    int FibonacciRecursive(int n)
    {
        if (n <= 1)
            return n;

        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }

    int FibonacciIterative(int n)
    {
        if (n <= 1)
            return n;

        int a = 0, b = 1, sum;

        for (int i = 2; i <= n; i++)
        {
            sum = a + b;
            a = b;
            b = sum;
        }

        return b;
    }
}
