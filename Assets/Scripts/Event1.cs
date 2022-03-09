/***********************************
 * Ryan Chen
 * March 4th
 * Event Handler, makes events progress
 * ********************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Event1 : MonoBehaviour
{
    //variables
    public GameObject[] buttons;
    public GameObject[] texts;
    public TMP_Text[] TMP_Text_Button;
    public TMP_Text TMPComponent;
    public string TextStrings = "";
    public float stage = 0;
    public GameObject stage0;
    public GameObject stage1;
    public GameObject stage2;
    public GameObject stage3;
    public bool happened = false;
    // Start is called before the first frame update
    void Start()
    {
        //sets tmpro text to this string
        TMPComponent.text = TextStrings;
        //if string is empty, set text to the first line
        if(TextStrings == "")
        {
            //set string to this 
            TMPComponent.text = "Game has Started, click the first box to continue";
            //set variable to the current text
            TextStrings = TMPComponent.text;
        }
        //grabbing six buttons here
        for(int i = 1; i <= buttons.Length; i++)
        {
            buttons[i - 1] = GameObject.FindGameObjectWithTag(i.ToString());
            Debug.Log(i.ToString() + " " + buttons.Length);
        }
        //loop through all 6 texts, set the text to an array.
       /* for (int i = 1; i <= 6; i++)
        {
            texts[i - 1] = GameObject.FindGameObjectWithTag("te" + i.ToString());
            //set all textmeshpros to TMP_Text_Button.
            TMP_Text_Button[i - 1] = texts[i - 1].GetComponent<TextMeshPro>();
        }*/
    }
    public void loser()
    {
        //if the text is this,
        if (TMPComponent.text == "Game has Started, click the first box to continue" && happened == false)
        {
            //set the text to this.
            TMPComponent.text = "The party stops at a state park and searches for supplies. How many times do you want your party to run over the area to search for supplies?";
            //do this four times, set the textmeshpro texts to the number 1-4
            for(int i = 0; i < 4; i++)
            {
                TMP_Text_Button[i] = texts[i].GetComponent<TMP_Text>();
                TMP_Text_Button[i].text = i.ToString();
            }
            happened = true;
        }
        //if the text is this,
        /*else if (TMPComponent.text == "The party stops at a state park and searches for supplies. How many times do you want your party to run over the area to search for supplies?")
        {
            //if you press button 1,
            if (this.gameObject == buttons[0])
            {

            }
            //if you press button 2,
            else if (this.gameObject == buttons[1])
            {

            }
            //if you press button 3,
            else if (this.gameObject == buttons[2])
            {

            }
            //if you press button 4,
            else if (this.gameObject == buttons[3])
            {

            }
            //if you press button 5,
            else if (this.gameObject == buttons[4])
            {
                TMP_Text_Button[5].text = ". . .";
            }
            //if you press button 6,
            else if (this.gameObject == buttons[5])
            {
                TMP_Text_Button[5].text = ". . .";
            }
            //if not any of the above,
            else
                Debug.Log("Error");
        }*/
    }
}
