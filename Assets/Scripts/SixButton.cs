/***********************************
 * Ryan Chen
 * March 4th
 * Makes the six buttons usable.
 * ********************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class SixButton : MonoBehaviour
{
    //variables
    public float VehicleCondition = 100;
    public float PO = 100;
    public float Supplies = 100;
    public List<TMP_Text> texts;
    public TMP_Text MainText;
    public TMP_Text[] loserettes;
    public GameObject[] losars;
    public GameObject[] buttons;
    public GameObject[] buttonstext;
    public GameObject[] backgrounds;
    public string[] buttonchoices1;
    public string[] buttonchoices2;
    public string[] buttonchoices3;
    public string[] buttonchoices4;
    public string[] buttonchoices5;
    public string[] buttonchoices6;
    public string[] scenarios;
    public int stage = 0;
    public int[] riskamount;
    public int[] stringtoint;
    // Start is called before the first frame update
    void Start()
    {
        //setting all the array sizes, so no errors appear.
        loserettes = new TMP_Text[3];
        losars = new GameObject[3];
        stringtoint = new int[buttonchoices1.Length];

        //setting all the arrays sizes and matching them with the correct gameobjects.
        buttonstext = GameObject.FindGameObjectsWithTag("textas");
        buttons = GameObject.FindGameObjectsWithTag("buton");
        losars[0] = GameObject.FindGameObjectWithTag("VC");
        losars[1] = GameObject.FindGameObjectWithTag("PO");
        losars[2] = GameObject.FindGameObjectWithTag("S");
        backgrounds = GameObject.FindGameObjectsWithTag("bg");

        //find components of the gameobjects.
        loserettes[0] = losars[0].GetComponent<TMP_Text>();
        loserettes[1] = losars[1].GetComponent<TMP_Text>();
        loserettes[2] = losars[2].GetComponent<TMP_Text>();

        //gets the components of all of the guis,
        for (int i = 0; i < buttonstext.Length; i++)
        {
            
            texts.Add(buttonstext[i].GetComponent<TMP_Text>());
        }
        if(stage == 0)
        {
            MainText.GetComponent<TMP_Text>().text = "The game has started, click any box when you are ready to start.";
            stage += 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(loserettes[1].tag);
        loserettes[0].text = "Vehicle Condition: " + VehicleCondition.ToString();
        loserettes[1].text = "Public Opinion: " + PO.ToString();
        loserettes[2].text = "Supplies: " + Supplies.ToString();
        Debug.Log("Vehicle Condition" + VehicleCondition.ToString() + "Public Opinion: " + PO.ToString() + "Supplies: " + Supplies);


        if (stage >= scenarios.Length + 1)
        {
           SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else if (stage == 1)
        {

        }
        else if(stage == 2)
        {
            backgrounds[0].SetActive(false);
         }
        else if (stage == 3)
        {
            backgrounds[1].SetActive(false);
        }
        else if(stage == 4)
        {
            backgrounds[2].SetActive(false);
        }
        else if(stage == 5)
        {
            stage = 4;
        }

    }
    public void button1()
    {
        stage2(0);
    }
    public void button2()
    {
        stage2(1);
    }
    public void button3()
    {
        stage2(2);
    }
    public void button4()
    {
        stage2(3);
    }
    public void button5()
    {
        stage2(4);
    }
    public void button6()
    {
        stage2(5);
    }
    private void stage2(int loser)
    {
        //if the stage is greater than 0, and less than the amount of button choices,
        if (stage > 0 && stage <= scenarios.Length)
        {
            //set stage to the next, and then 
            stage += 1;
            MainText.GetComponent<TMP_Text>().text = scenarios[stage - 2];
            if (stage - 2 < buttonchoices1.Length)
            {
                texts[0].text = buttonchoices1[stage - 2];
                texts[1].text = buttonchoices2[stage - 2];
                texts[2].text = buttonchoices3[stage - 2];
                texts[3].text = buttonchoices4[stage - 2];
                texts[4].text = buttonchoices5[stage - 2];
                texts[5].text = buttonchoices6[stage - 2];
            }
        }
    }
}
