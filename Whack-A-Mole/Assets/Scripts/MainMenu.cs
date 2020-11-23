using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play() // Loads the game scene
    {
        SceneManager.LoadScene("Game");
    }

    public void Quit() // Quits the game
    {
        Application.Quit(); 
        Debug.Log("Quit");
    }
}
