using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleClicked : MonoBehaviour
{
    public GameObject GameManager;
    public float removeTimeOnMiss = 10;

    void Update()
    {
        if (Time.deltaTime != 0) // Dont run the input method if the time is stopped
        {
            Input();
        }  
    }

    void Input()
    {
        /*
        ITakeDamage damagable = collider.GetComponent<ITakeDamage>(); // Damageable is anything with the ITakeDamage interface
        if (damagable != null) // If the thing hit with raycast is damagable then give the TakeDamage method 1f damage every click
        {
            damagable.TakeDamage(1.0f);
        }
        else
        {
            Debug.Log("Didn't hit target");
            GameManager.GetComponent<Timer>().timer -= removeTimeOnMiss; // Remove 10 seconds from the variable in the Timer script if hit the ground
        }
        */
    }
}
