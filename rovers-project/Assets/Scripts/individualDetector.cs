using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class individualDetector : MonoBehaviour
{

    void Start()
    {
        gameObject.tag = "Component";
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Radiation")
        {
            Debug.Log("Radiation Detected on component: " + gameObject.name);
            Debug.Log("Radiation level: " + other.name);
        }
    }


}
