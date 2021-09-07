using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class individualDetector : MonoBehaviour
{
    [SerializeField] private Slider healthbarSlider;

    private int maximumHealth;
    private int currentHealth;


    void Start()
    {
        gameObject.tag = "Component";
        maximumHealth = 100;
        currentHealth = maximumHealth;
        SetHealthbarUI();
    }

    // Make this tick on timer. Maybe use OnTriggerStay?
    private void OnTriggerEnter(Collider other) 
    {
        if (other.tag == "Radiation")
        {
            Debug.Log("Radiation Detected on component: " + gameObject.name);
            Debug.Log("Radiation level: " + other.name);

            if (other.name == "radiation-low")
            {
                currentHealth = currentHealth - 3;
                SetHealthbarUI();
            }
            else if (other.name == "radiation-med")
            {
                currentHealth = currentHealth - 5;
                SetHealthbarUI();
            }
            else if (other.name == "radiation-high")
            {
                currentHealth = currentHealth - 8;
                SetHealthbarUI();
            }

        }
    }

    private void SetHealthbarUI()
    {
        healthbarSlider.value = currentHealth;

    }


}
