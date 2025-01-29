using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WholeScript : MonoBehaviour
{
    float scaleSensitivity = 1.0f;
    float wholeScaleFactor = 0f;

    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            wholeScaleFactor += Input.GetAxis("Mouse Y") * scaleSensitivity * Time.deltaTime;
            wholeScaleFactor = Mathf.Clamp(wholeScaleFactor, 0, 1);
            transform.localScale = new Vector3(wholeScaleFactor, wholeScaleFactor, wholeScaleFactor);
        }
    }
}
