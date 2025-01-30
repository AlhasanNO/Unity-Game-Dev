using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Assignment35
{
    public class UnityEventExample : MonoBehaviour
    {
        public UnityEvent onEventTriggred;

        // Start is called before the first frame update
        void Start()
        {
            onEventTriggred = new();
            onEventTriggred.AddListener(onEventResponse);
        }

        // Update is called once per frame
        void Update()
        {
            onEventTriggred.Invoke();
        }

        void onEventResponse()
        {
            if (Input.GetKeyDown(KeyCode.Space))
                Debug.Log("The event has been triggered!");
        }
    }
}