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
        ree = GameObject.FindGameObjectsWithTag("Loser");
        for (int i = 0; i < ree.Length; i++)
        {
            ree[i].GetComponent<SpriteRenderer>().enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void clickyclicky()
    {
        
        LoserBool = true;
        LoserImoogas.SetActive(true);
        loserette = 0;
        for (int i = 0; i < ree.Length; i++)
        {
            if (LoserImoogas.gameObject == ree[i])
            {
                LoserImoogas.GetComponent<SpriteRenderer>().enabled = true;
            }
            else
            {
                ree[i].GetComponent<SpriteRenderer>().enabled = false;
            }
        }
    }
}
