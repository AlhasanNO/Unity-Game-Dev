using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpScript : MonoBehaviour
{
    float bookRotationSensitivity = 90.0f;
    float xAngle = 0.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            xAngle += Input.GetAxis("Mouse Y") * bookRotationSensitivity * Time.deltaTime;
            xAngle = Mathf.Clamp(xAngle, 0, 90);
            transform.rotation = Quaternion.Euler(xAngle, 0, 0);
        }
    }
}
