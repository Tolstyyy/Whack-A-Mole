using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timer = 30f;              // Time left in the game
    public GameObject failMenuUI;       // Reference to the fail menu ui
    public GameObject gameUI;
    public GameObject spawner;

    public GameObject[] hands;
    public GameObject hammer;

    
    void Update() // Updates the body every frame
    {
        timer -= Time.deltaTime; // Basically a timer. The value set in the fTimer is minus time each frame

        if (timer <= 0) // If the timer has reached 0 or is below it stop the time
        {
            Debug.Log("Out of time");

            Destroy(spawner);

            hammer.SetActive(false);

            foreach(var hand in hands)
            {
                hand.SetActive(true);
            }

            gameUI.SetActive(false);
        }

        if (timer <= 0) // If timer has reached 0
        {
            failMenuUI.SetActive(true); // Show the failmenu
        }      
    }
}
