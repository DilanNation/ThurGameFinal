using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Animator doorAnimator;
    public GameObject doorOpenSound;
    public bool spawnable;
    public GameObject WorldSegment;
    public Transform SpawnPoint;
    [HideInInspector]
    public bool isInterectable = true;
    public bool needsKey;

    public void Open() 
    {
        if (isInterectable) 
        {
            doorAnimator.enabled = true;
            doorOpenSound.SetActive(true);

            if (spawnable) 
            {
                Instantiate(WorldSegment, SpawnPoint.position, SpawnPoint.rotation);

                EventHandler eventHandler = FindObjectOfType<EventHandler>();
                eventHandler.Spawned();
            }
        }
    }
}
