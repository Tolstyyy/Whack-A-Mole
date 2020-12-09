using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitMole : MonoBehaviour
{
    public Timer timerScript; // Reference to timerscript on this gameobject
    public float removeTimeOnMiss = 10; // Amount of time to remove when missed
    public float speedWhenRegistered = 1f; // The speed (per sec) the hammer needs to be at to register a hit

    private ParticleSystem hitParticle; // Particle system prefab in mole prefab

    private Vector3 oldPosition;
    private float speedPerSec;

    void FixedUpdate()
    {
        speedPerSec = Vector3.Distance(oldPosition, transform.position) / Time.deltaTime;
        oldPosition = transform.position;
    }

    private void OnTriggerEnter(Collider info)
    {
        ITakeDamage damagable = info.GetComponent<ITakeDamage>(); // Damageable is anything with the ITakeDamage interface

        // If hammer is moving fast enough and it hit a mole
        if (speedPerSec > speedWhenRegistered && damagable != null)
        {
            // Play hit particle system
            hitParticle = info.GetComponentInChildren<ParticleSystem>();
            hitParticle.Play();

            // Add damage to the mole that was hit
            damagable.TakeDamage(1.0f);          
        }
        
        if (speedPerSec > speedWhenRegistered && damagable == null)
        {
            // Remove time from timer on miss
            //timerScript.timer -= removeTimeOnMiss;
        }
    }
}
