using UnityEngine;

public class CameraScript : MonoBehaviour
{
    Vector3 targetPosition;
    Quaternion targetRotation;
    float transitionSpeed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        targetPosition = transform.position;
        targetRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            targetPosition = new Vector3(-0.5f, 183.9429f, -56f);
            targetRotation = Quaternion.Euler(30f, 0f, 0f);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            targetPosition = new Vector3(0.5f, 156f, 13f);
            targetRotation = Quaternion.Euler(0f, 0f, 0f);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            targetPosition = new Vector3(2.5f, 175f, 25f);
            targetRotation = Quaternion.Euler(90f, 0f, 0f);
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            targetPosition = new Vector3(34f, 115f, 12f);
            targetRotation = Quaternion.Euler(0f, -60f, 0f);
        }

        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * transitionSpeed);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * transitionSpeed);
    }
}
