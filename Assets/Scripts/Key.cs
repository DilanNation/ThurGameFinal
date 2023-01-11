using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public Door door;
    public GameObject keySound;
    public void Equip() {
        door.needsKey = false;
        Destroy(gameObject);
        keySound.SetActive(true);
    }
}
