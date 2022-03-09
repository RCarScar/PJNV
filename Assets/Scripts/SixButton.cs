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
    public TextMeshProUGUI[] texts;
    public TextMeshProUGUI MainText;
    public TextMeshProUGUI[] loserettes;
    public GameObject[] losars;
    public GameObject[] buttons;
    public GameObject[] buttonstext;
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
        texts = new TextMeshProUGUI[buttonstext.Length];
        loserettes = new TextMeshProUGUI[3];
        stringtoint = new int[buttonchoices1.Length];
        //setting all the arrays sizes and matching them with the correct gameobjects.
        buttons = GameObject.FindGameObjectsWithTag("buton");
        buttonstext = GameObject.FindGameObjectsWithTag("textas");
        losars[0] = GameObject.FindGameObjectWithTag("VC");
        losars[1] = GameObject.FindGameObjectWithTag("PO");
        losars[2] = GameObject.FindGameObjectWithTag("S");
        loserettes[0] = losars[0].GetComponent<TextMeshProUGUI>();
        loserettes[1] = losars[1].GetComponent<TextMeshProUGUI>();
        loserettes[2] = losars[2].GetComponent<TextMeshProUGUI>();
        //gets the components of all of the guis,
        for (int i = 0; i < buttonstext.Length; i++)
        {
            texts[i] = buttonstext[i].GetComponent<TextMeshProUGUI>();
        }
        if(stage == 0)
        {
            MainText.GetComponent<TextMeshProUGUI>().text = "The game has started, click any box when you are ready to start.";
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(loserettes.Length.ToString());
        Debug.Log(loserettes[1].tag);
        loserettes[0].text = "Vehicle Condition: " + VehicleCondition.ToString();
        loserettes[1].text = "Public Opinion: " + PO.ToString();
        loserettes[2].text = "Supplies: " + Supplies.ToString();

        
        if(stage > scenarios.Length)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }
    public void button1()
    {
        stage2(0);
        if (stage >= 1 && stage >= scenarios.Length)
        {
            stringtoint[stage - 1] = int.Parse(buttonchoices1[stage - 1]);
            Debug.Log(stringtoint[stage - 1]);
        }
    }
    public void button2()
    {
        stage2(1);
        if (stage >= 1 && stage >= scenarios.Length)
        {
            stringtoint[stage - 1] = int.Parse(buttonchoices2[stage - 1]);
            Debug.Log(stringtoint[stage - 1]);
        }
    }
    public void button3()
    {
        stage2(2);
        if (stage >= 1 && stage >= scenarios.Length)
        {
            stringtoint[stage - 1] = int.Parse(buttonchoices3[stage - 1]);
            Debug.Log(stringtoint[stage - 1]);
        }
    }
    public void button4()
    {
        stage2(3);
        if (stage >= 1 && stage >= scenarios.Length)
        {
            stringtoint[stage - 1] = int.Parse(buttonchoices4[stage - 1]);
            Debug.Log(stringtoint[stage - 1]);
        }
    }
    public void button5()
    {
        stage2(4);
        if (stage >= 1 && stage >= scenarios.Length)
        {
            stringtoint[stage - 1] = int.Parse(buttonchoices5[stage - 1]);
            Debug.Log(stringtoint[stage - 1]);
        }
    }
    public void button6()
    {
        stage2(5);
        if (stage >= 1 && stage >= scenarios.Length)
        {
            stringtoint[stage - 1] = int.Parse(buttonchoices6[stage - 1]);
            Debug.Log(stringtoint[stage - 1]);
        }
    }
    private void stage2(int loser)
    {
        stringtoint[stage - 1] = 0;
        stage += 1;
        MainText.GetComponent<TextMeshProUGUI>().text = scenarios[stage - 1];
        texts[0].text = buttonchoices1[stage - 1];
        texts[1].text = buttonchoices2[stage - 1];
        texts[2].text = buttonchoices3[stage - 1];
        texts[3].text = buttonchoices4[stage - 1];
        texts[4].text = buttonchoices5[stage - 1];
        texts[5].text = buttonchoices6[stage - 1];
    }
}
