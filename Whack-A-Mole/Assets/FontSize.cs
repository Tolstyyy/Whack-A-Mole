using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FontSize : MonoBehaviour
{
    public TextMeshProUGUI[] texts; // The texts you want to change to change the font of

    // Dynamic function for the event on the button
    public void IncreaseFontSize(float size)
    {
        foreach (var text in texts)
        {
            text.fontSize += size; // Increase font size of all texts in the array with whatever value the button outputs
        }
    }

    public void DecreaseFontSize(float size)
    {
        foreach (var text in texts)
        {
            text.fontSize -= size; // Decrease font size of all texts in the array with whatever value the button outputs
        }
    }
}
