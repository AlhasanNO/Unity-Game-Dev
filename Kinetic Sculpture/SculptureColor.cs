using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SculptureColor : MonoBehaviour
{
    float time = 0f;
    public Color startColor = Color.green;
    public Color endColor = Color.blue;
    public Light sculptureLight;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        float t = Mathf.PingPong(time, 1f);
        sculptureLight.color = Color.Lerp(startColor, endColor, t);
    }
}
