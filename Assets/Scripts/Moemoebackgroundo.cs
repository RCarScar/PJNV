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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loserette()
    {

            game[0].SetActive(false);
            game[1].SetActive(true);
    }
}
