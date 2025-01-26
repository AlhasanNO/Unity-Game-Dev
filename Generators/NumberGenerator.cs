using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int i = 0;

        while (i < 20)
        {
            int random = Random.Range(1, 21);
            i++;
            if (random == 5) continue;
            else if (random == 15) break;
            Debug.Log(random);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
