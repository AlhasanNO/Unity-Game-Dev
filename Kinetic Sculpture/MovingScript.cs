using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingScript : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

        float New = Mathf.Sin(Time.time);
        transform.rotation = Quaternion.Euler(new Vector3(0f, New * 30f, New * 30f));
    }
}
