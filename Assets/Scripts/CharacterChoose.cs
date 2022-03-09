/***********************************
 * Ryan Chen
 * March 4th
 * Event Handler, makes events progress
 * ********************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterChoose : MonoBehaviour
{
    public GameObject fudger;
    public GameObject LoserImoogas;
    public GameObject removera;
    public GameObject removera2;
    public GameObject Losertaxes;
    public GameObject[] ree;
    int goldennumber = 0;
    int pair1 = 0;
    int pair2 = 0;
    int loserette = 0;
    bool LoserBool = false;

    // Start is called before the first frame update
    void Start()
    {
        //set gameobject ree to all gameobjects with tag "Loser"
        ree = GameObject.FindGameObjectsWithTag("Loser");
        removera2 = GameObject.FindGameObjectWithTag("check");
        //repeat this process for the length of ree,
        for (int i = 0; i < ree.Length; i++)
        {
            //set the currently selected ree so that the sprite renderer is disabled.
            ree[i].GetComponent<SpriteRenderer>().enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (LoserImoogas.gameObject == ree[1])
        {
            if (ree[0].GetComponent<SpriteRenderer>().enabled == true)
            {
                removera.SetActive(true);
            }
            else if (ree[1].GetComponent<SpriteRenderer>().enabled == true)
            {
                removera.SetActive(false);
            }
        }
        else if(LoserImoogas.gameObject == ree[0])
        {
            if (ree[0].GetComponent<SpriteRenderer>().enabled == true)
            {
                removera.SetActive(false);
            }
            else if (ree[1].GetComponent<SpriteRenderer>().enabled == true)
            {
                removera.SetActive(true);
            }
        }
    }
    public void clickyclicky()
    {
        //set this bool to true,
        LoserBool = true;
        //set this gameobject to active.
        LoserImoogas.SetActive(true);
        //set loserette to 0, an integer with no current value.
        loserette = 0;
        //repeat for the length of ree.
        for (int i = 0; i < ree.Length; i++)
        {
            //if the picture is the picture in the gameobject, enable.
            if (LoserImoogas.gameObject == ree[i])
            {
                Losertaxes.SetActive(false);
                removera2.SetActive(true);
                LoserImoogas.GetComponent<SpriteRenderer>().enabled = true;

            }
            //if the picture is not the picture in the gameobject, disable
            else
            {
                ree[i].GetComponent<SpriteRenderer>().enabled = false;
            }
        }
    }
}
