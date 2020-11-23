using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class FailMenuUI : MonoBehaviour
{
    public TextMeshProUGUI yourScore;       // Reference for the final score when game is failed
    public TextMeshProUGUI yourBest;        // Reference for the highscore text
    public GameObject GameManager;          // Reference for the game manager

    void Update()
    {
        yourScore.text = "Your moles: " + GameManager.GetComponent<Score>().molesClicked.ToString(); // Set the final score from the Score script in Gamemanager to the yourscore text component referenced earlier
        yourBest.text =  "Your best: " + PlayerPrefs.GetInt("HighScore");                            // Set your best score to the text component referenced earlier. Highscore is derived from the HighScore key saved initially in the Score script       
    }

    #region Buttons
    public void Restart() // Loads the game scene
    {
        SceneManager.LoadScene("Game");
    }

    public void Quit() // Quits the game
    {
        Application.Quit();
        Debug.Log("Quit");
    }
    #endregion
}
