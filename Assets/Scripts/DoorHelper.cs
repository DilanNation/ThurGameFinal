using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DoorHelper : MonoBehaviour
{
    public float radius;
    public GameObject openDoorText;
    public GameObject requiresKeyText;
    public GameObject takeKeyText;
    Door door;
    public UnityEvent onDoorOpened;
         

    private void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, radius))
        {
            Door door = hit.transform.GetComponent<Door>();
            if (hit.transform.GetComponent<Door>() && door.needsKey == false)
            {
                openDoorText.gameObject.SetActive(true);
                if (Input.GetKeyDown(KeyCode.F))
                {
                    door.Open();
                    door.isInterectable = false;
                    openDoorText.gameObject.SetActive(false);
                    onDoorOpened.Invoke();
                }
            } 
            
            if (door != null && door.needsKey) { 
                requiresKeyText.SetActive(true);
            }


            if (hit.transform.GetComponent<Key>())
            {
                takeKeyText.gameObject.SetActive(true);
                if (Input.GetKeyDown(KeyCode.F)) { 
                    Key key = hit.transform.GetComponent<Key>();
                    key.Equip();
                    takeKeyText.SetActive(false);
                }
            }
        }
        else {
            openDoorText.gameObject.SetActive(false);
            requiresKeyText.SetActive(false);
            takeKeyText.SetActive(false);
        }
        
    }
}
