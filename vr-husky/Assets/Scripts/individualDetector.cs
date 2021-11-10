using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class individualDetector : MonoBehaviour
{
    [SerializeField] private Slider healthbarSlider;

    public float maximumHealth;
    public float currentHealth;
    private bool TimerStarted;


    void Start()
    {
        gameObject.tag = "Component";
        maximumHealth = 100f;
        currentHealth = maximumHealth;
        TimerStarted = false;
        SetHealthbarUI();
    }

    // Initial damage to component on trigger enter
    private void OnTriggerEnter(Collider radCollider) 
    {
        if (radCollider.tag == "Radiation")
        {
            Debug.Log("Radiation Detected on component: " + gameObject.name);
            Debug.Log("Radiation level: " + radCollider.name);

            if (radCollider.name == "radiation-low")
            {
                currentHealth = currentHealth - 3.0f;
                SetHealthbarUI();
            }
            else if (radCollider.name == "radiation-med")
            {
                currentHealth = currentHealth - 5.0f;
                SetHealthbarUI();
            }
            else if (radCollider.name == "radiation-high")
            {
                currentHealth = currentHealth - 8.0f;
                SetHealthbarUI();
            }

        }
    }

    // Damage ticks per frame staying in the radiation site
    private void OnTriggerStay(Collider radCollider) 
    {
        if (radCollider.tag == "Radiation")
        {
            if (radCollider.name == "radiation-low")
            {
                currentHealth = currentHealth - 0.03f;
                SetHealthbarUI();
            }
            else if (radCollider.name == "radiation-med")
            {
                currentHealth = currentHealth - 0.05f;
                SetHealthbarUI();
            }
            else if (radCollider.name == "radiation-high")
            {
                currentHealth = currentHealth - 0.08f;
                SetHealthbarUI();
            }

        }
    }

    private void SetHealthbarUI()
    {
        healthbarSlider.value = currentHealth;

    }


}
