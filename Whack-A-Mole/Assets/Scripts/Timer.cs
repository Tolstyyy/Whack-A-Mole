using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timer = 30f;              // Time left in the game
    public GameObject failMenuUI;       // Reference to the fail menu ui

    
    void Update() // Updates the body every frame
    {
        timer -= Time.deltaTime; // Basically a timer. The value set in the fTimer is minus time each frame

        if (timer <= 0) // If the timer has reached 0 or is below it stop the time
        {
            Debug.Log("Out of time");
            Time.timeScale = 0f;           
        }
        else // If not set the time speed back to normal
        {
            Time.timeScale = 1f;
        }

        if (Time.timeScale == 0) // If time has stopped
        {
            failMenuUI.SetActive(true); // Show the failmenu
        }
        else
        {
            failMenuUI.SetActive(false); // Otherwise hide it
        }
    }
}
