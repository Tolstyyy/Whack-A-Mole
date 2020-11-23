using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mole : MonoBehaviour, ITakeDamage
{
    public float moleHealth = 1.0f;                 // Health of the mole
    public float moleDestroyTime = 1.5f;            // Time it takes to destroy the mole
    private GameObject gameManager;                 // Game manager gameobject reference

    public void Start()
    {
        Destroy(gameObject, moleDestroyTime); // Destroy the mole when it spawns after x amount of seconds
        gameManager = GameObject.FindGameObjectWithTag("Manager"); // Find the game manager
    }

    public void TakeDamage(float damage)
    {
        moleHealth -= damage;
        if (moleHealth <= 0)
        {      
            gameManager.GetComponent<Score>().molesClicked++; // Increment amount of moles clicked variable in the Score script attached to game manager
            gameManager.GetComponent<Timer>().timer += 2f; // Add 2 seconds to the timer in the Timer script attached to the game manager
            Destroy(gameObject); // Destroy the mole
        }
    }
}
