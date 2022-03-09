/***********************************
 * Ryan Chen
 * March 4th
 * Event Handler, makes events progress
 * ********************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moemoebackgroundo : MonoBehaviour
{
    public bool agentselected = false;
    public GameObject[] game;
    public GameObject losera;
    // Start is called before the first frame update
    void Start()
    {
        losera = GameObject.FindGameObjectWithTag("check");
        losera.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loserette()
    {
        if (losera.activeInHierarchy == true)
        {
            game[0].SetActive(false);
            game[1].SetActive(true);
        }
    }
}
