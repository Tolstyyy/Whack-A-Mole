using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleSpawn : MonoBehaviour
{
    public GameObject mole;                     // Reference to the mole prefab                       
    public GameObject buffMole;                 // Reference to the buffMole variant of mole prefab

    public float buffMoleSpawnChance = 0.1f;    // Chance to spawn a buff mole 
    public int amountOfMolesToSpawn = 1;        // Amount of moles to spawn each time
    public float minPos = -5f, maxPos = 5f;     // Spawn range of moles

    private int moleCount;                      // Number of moles in the scene

    private void Update()
    {
        moleCount = GameObject.FindGameObjectsWithTag("Mole").Length; // The number of moles is the number of gameobjects found with the "Mole" tag

        if (moleCount == 0) // If there are no moles in the scene spawn 1 mole
        {
            Spawn(amountOfMolesToSpawn);
        }       
    }

    void Spawn(int amount)
    {
        var position = new Vector3(Random.Range(minPos, maxPos), 0, Random.Range(minPos, maxPos)) + transform.position; // Min/max position of where the moles spawn plus the transform of gameobject working as an offset
        
        for (int i = 0; i < amount; i++)
        {
            if (Random.value < buffMoleSpawnChance)
            {
                Instantiate(buffMole, position, Quaternion.identity);
            }
            else
            {
                Instantiate(mole, position, Quaternion.identity);
            }       
        }
    }
}
