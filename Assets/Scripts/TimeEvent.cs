using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TimeEvent : MonoBehaviour
{
    public TimedEvent[] timedEvent;
    float Timer;


    void Update()
    {
         Timer += Time.deltaTime;

        foreach (TimedEvent events in timedEvent)
        {
            if (Timer >= events.Time) {
                events.afterTime.Invoke();
            }
        }
    }

}

[System.Serializable]
public class TimedEvent {

    public string name;
    public float Time;
    public UnityEvent afterTime;
    bool hasHappend;
    
}

