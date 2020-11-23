using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public int molesClicked;                    // Amount of moles that have been clicked 
    
    [Header("Text")]
    public TextMeshProUGUI scoreText;           // Reference to the score text
    public TextMeshProUGUI highScoreText;       // Reference to the highscore text
    public TextMeshProUGUI timerText;           // Reference to the timer text

    [Header("TextObjects")]
    public GameObject highScoreObject;          // Reference to the Gameobject containing the highscore text
    public GameObject scoreObject;              // Reference to the Gameobject containing the score text
    public GameObject timerObject;              // Reference to the Gameobject containing the timer text

    private Timer timerRef;

    void Start()
    {
        timerRef = GetComponent<Timer>();
        molesClicked = 0; // Shows 0 in the string
    }

    void Update() // Execute the referenced methods below every frame
    {
        TimeLeft();
        MoleScore();
        ShowHighscore();
    }

    private void TimeLeft() 
    {
        timerText.text = "Time: " + timerRef.timer.ToString("f0"); // Sets the timer variable from Timer script to the timerText TextMeshProUGUI component referenced earlier

        if (Time.deltaTime == 0) // Hide the timer object containing the textmesh component whenever time is stopped. If not make it true
        {
            timerObject.SetActive(false);
        }
        else
        {
            timerObject.SetActive(true);
        }
    }

    public void MoleScore()
    {
        scoreText.text = "Moles: " + molesClicked.ToString(); // Sets the molesclicked variable to the text component

        if (Time.deltaTime == 0) // Hide the mole score object containing the textmesh component whenever time is stopped. If not make it true
        {
            scoreObject.SetActive(false);
        }
        else
        {
            scoreObject.SetActive(true);
        }
    }

    public void ShowHighscore() // Show highscore when a new highscore is reached
    {
        if (molesClicked > PlayerPrefs.GetInt("HighScore", 0)) // Whenever the current score is more than your highest score it will become visible and save the new highscore. 
        {
            highScoreObject.SetActive(true); // Show the highscoretext object

            PlayerPrefs.SetInt("HighScore", molesClicked); // Stores the molesclicked variable somewhere in the local computer
            highScoreText.text = "Highscore: " + molesClicked.ToString(); // Set the variable to a string and display in the text box            
        }
        else if (molesClicked < PlayerPrefs.GetInt("HighScore", 0)) // and if the molesclicked variable isnt more than your highscore then hide the highscore text object
        {
            highScoreObject.SetActive(false); // Hide the highscoretext object
        }

        if (Time.deltaTime == 0) // If the time is stopped hide the highscore object
        {
            highScoreObject.SetActive(false);
        }

       
    }

    #region Buttons
    public void ResetHighScore() // Deletes highscore (used with a temporary button)
    {
        PlayerPrefs.DeleteKey("HighScore");
        highScoreText.text = "Highscore: 0";
    }
    #endregion
}