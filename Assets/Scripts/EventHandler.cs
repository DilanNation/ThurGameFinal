using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class EventHandler : MonoBehaviour
{
    public int timesSpawned;
    public int desiredSpawned = 3;
    public int desiredSpawned2 = 6;
    public Light[] pointLights;

    
    void Update()
    {
        if (timesSpawned >= desiredSpawned)
        {
            pointLights = FindObjectsOfType<Light>();
            for (int i = 0; i < pointLights.Length; i++)
            {
                pointLights[i].color = Color.red;
            }
        }
        if (timesSpawned >= desiredSpawned2)
        {
            for (int i = 0; i < pointLights.Length; i++)
            {
                pointLights[i].color = Color.green;
            }
        }
    }

    public void Spawned() 
    {
        timesSpawned++;
    }
}
