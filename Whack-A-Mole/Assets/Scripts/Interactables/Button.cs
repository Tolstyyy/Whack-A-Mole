using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BoxCollider))]
public class Button : MonoBehaviour
{
    public UnityEvent onButtonPressed;
    public UnityEvent onButtonExit;
    //private GameObject button;
    private readonly bool pressed = false;

    void OnTriggerEnter(Collider button)
    {
        if (button.CompareTag("button") && !pressed)
        {
            // Make a click sound
            Debug.Log("Button Pressed");
            onButtonPressed?.Invoke();
        }
    }

    void OnTriggerExit(Collider button)
    {
        if (button.CompareTag("button") && !pressed)
        {
            // Make a click sound
            Debug.Log("Button Left");
            onButtonExit?.Invoke();
        }
    }
}