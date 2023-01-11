using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomProp : MonoBehaviour
{
    public GameObject[] Props;

    private void Start()
    {
        int rn = Random.Range(0, Props.Length);
        for (int i = 0; i < Props.Length; i++)
        {
            Props[i].SetActive(false);
        }
        Props[rn].SetActive(true);
    }
}
