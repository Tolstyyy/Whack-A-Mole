using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLimit : MonoBehaviour
{
    public GameObject buttonTrigger;
    private Vector3 orignialPos;
    private float minDistance;
    private float maxDistance;

    void Awake()
    {
        minDistance = Vector3.Distance(buttonTrigger.transform.position, transform.position);
        maxDistance = buttonTrigger.transform.position.y;

        orignialPos = transform.position;
    }

    void Update()
    {
        if(Vector3.Distance(buttonTrigger.transform.position, transform.position) >= minDistance)
        {
            transform.position = orignialPos;
        }

        if(transform.position.y <= maxDistance)
        {
            transform.position = new Vector3(transform.position.x, maxDistance, transform.position.z);
        }
    }
}
