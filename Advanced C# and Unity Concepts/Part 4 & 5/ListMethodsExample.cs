using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment35
{
    public class ListMethodsExample : MonoBehaviour
    {
        List<int> numbers1 = new() { 3, 1, 4, 1, 5, 9 };
        
        List<int> numbers2 = new() { 3, 1, 4, 1, 5, 9, 2, 6 };
        List<int> filteredNumbers = new();

        // Start is called before the first frame update
        void Start()
        {
            numbers1.Sort((x, y) => y.CompareTo(x));
            Debug.Log(string.Join(", ", numbers1));

            filteredNumbers = numbers2.FindAll(number => number % 2 == 0);
            Debug.Log(string.Join(", ", filteredNumbers));
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}