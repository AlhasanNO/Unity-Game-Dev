using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBodyCharacterController : MonoBehaviour
{
    static float characterSpeed = 1.0f;
    static float jumpUp = 1.0f;

    Vector3 forward = new(0f, 0f, characterSpeed);
    Vector3 backward = new(0f, 0f, -characterSpeed);
    Vector3 right = new(characterSpeed, 0f, 0f);
    Vector3 left = new(-characterSpeed, 0f, 0f);
    Vector3 jump = new(0f, jumpUp, 0f);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += forward * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += backward * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += right * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += left * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += jump * Time.deltaTime;
        }
    }
}
