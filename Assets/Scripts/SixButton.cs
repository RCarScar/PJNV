using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SixButton : MonoBehaviour
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
    public string first = "The party stops at a state park and searches for supplies. How many times do you want your party to run over the area to search for supplies?";
    public string second = "The party stops at a motel and your team enters a guest convenience store. Do you want to gather supplies, or rob the store?";
    public string third = "The party stops at a farm, and they are welcomed with a free breakfast and a bed. How long do you plan to stay for?";
    public string fourth = "child";
    public string fifth = "literal loser";
    public string sixth = "actual loser";
    public string seventh = "nobody likes you";
    public string eighth = "you're sad";
    public string ninth = "bad.";
    public bool[] done;
    // Start is called before the first frame update
    void Start()
    {
        //grabbing six buttons here
        for (int i = 1; i <= 6; i++)
        {
            buttons[i - 1] = GameObject.FindGameObjectWithTag(i.ToString());
            Debug.Log(i.ToString());
        }
        //loop through all 6 texts, set the text to an array.
        for (int i = 1; i <= 6; i++)
        {
            texts[i - 1] = GameObject.FindGameObjectWithTag("te" + i.ToString());
            //set all TMP_Texts to TMP_Text_Button.
          //  TMP_Text_Button[i - 1] = texts[i - 1].GetComponent<TMP_Text>();
        }
        for(int i = 0; i < 9; i++)
        {
            done[i] = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //if the text is set to nothing, set it to the first variable string of text.
        if (TMPComponent.text == "" && done[0] == false)
        {
            TMPComponent.text = first;
            done[0] = true;
        }
        //if the text is the first text, then run it once and then add one to the stage. so 2.
        else if (TMPComponent.text == first && done[1] == false)
        {
            stage += 1;
            done[1] = true;
        }
        //if the text matches the second variable, then run this once and then set the stage to 3.
        else if (TMPComponent.text == second && done[2] == false)
        {
            stage += 1;
            done[2] = true;
        }
        //if the text matches the third variable, then run this once and set the stage to 4.
        else if (TMPComponent.text == third && done[3] == false)
        {
            stage += 1;
            done[3] = true;
        }
        //if the text matches the fourth variable, then run this once and set the stage to 5. 
        else if (TMPComponent.text == fourth && done[4] == false)
        {
            stage += 1;
            done[4] = true;
        }
        //if the text matches the fifth variable, then run this once and set the stage to 6. just repeat this for the rest i'm not typing this out.
        else if (TMPComponent.text == fifth && done[5] == false)
        {
            stage += 1;
            done[5] = true;
        }
        else if (TMPComponent.text == sixth && done[6] == false)
        {
            stage += 1;
            done[6] = true;
        }
        else if (TMPComponent.text == seventh && done[7] == false)
        {
            stage += 1;
            done[7] = true;
        }
        else if (TMPComponent.text == eighth && done[8] == false)
        {
            stage += 1;
            done[8] = true;
        }
        else if (TMPComponent.text == ninth && done[9] == false)
        {
            stage += 1;
            done[9] = true;
        }
    }
    public void button1()
    {
        int number = 0;
        if (stage == 1) TMP_Text_Button[number].GetComponent<TMP_Text>().text = ("1");
        if (stage == 2)
        {
            TMP_Text_Button[number].GetComponent<TMP_Text>().text = ("beg");
            TMPComponent.text = third;
        }
        if (stage == 3)
        {
            TMP_Text_Button[number].GetComponent<TMP_Text>().text = ("1 night");
            TMPComponent.text = fourth;
        }
            if (stage == 4) TMP_Text_Button[number].GetComponent<TMP_Text>().text = ("1");
        if (stage == 5) TMP_Text_Button[number].GetComponent<TMP_Text>().text = ("1");
        if (stage == 6) TMP_Text_Button[number].GetComponent<TMP_Text>().text = ("1");
        if (stage == 7) TMP_Text_Button[number].GetComponent<TMP_Text>().text = ("1");
        if (stage == 8) TMP_Text_Button[number].GetComponent<TMP_Text>().text = ("1");
        if (stage == 9) TMP_Text_Button[number].GetComponent<TMP_Text>().text = ("1");
    }
    public void button2()
    {
        int number = 1;
        if (stage == 1) TMP_Text_Button[number].GetComponent<TMP_Text>().text = ("2");
        if (stage == 2)
        {
            TMP_Text_Button[number].GetComponent<TMP_Text>().text = ("steal");
            TMPComponent.text = second;
        }
        if (stage == 3)
        {
            TMP_Text_Button[number].GetComponent<TMP_Text>().text = ("2 nights");
            TMPComponent.text = fourth;
        }
        if (stage == 4) TMP_Text_Button[number].GetComponent<TMP_Text>().text = ("1");
        if (stage == 5) TMP_Text_Button[number].GetComponent<TMP_Text>().text = ("1");
        if (stage == 6) TMP_Text_Button[number].GetComponent<TMP_Text>().text = ("1");
        if (stage == 7) TMP_Text_Button[number].GetComponent<TMP_Text>().text = ("1");
        if (stage == 8) TMP_Text_Button[number].GetComponent<TMP_Text>().text = ("1");
        if (stage == 9) TMP_Text_Button[number].GetComponent<TMP_Text>().text = ("1");
    }
    public void button3()
    {
        int number = 2;
        if (stage == 1) TMP_Text_Button[number].GetComponent<TMP_Text>().text = ("3");
        if (stage == 2)
        {
            TMP_Text_Button[number].GetComponent<TMP_Text>().text = (". . .");
            TMPComponent.text = second;
        }
        if (stage == 3)
        {
            TMP_Text_Button[number].GetComponent<TMP_Text>().text = ("3 nights");
            TMPComponent.text = fourth;
        }
        if (stage == 4) TMP_Text_Button[number].GetComponent<TMP_Text>().text = ("1");
        if (stage == 5) TMP_Text_Button[number].GetComponent<TMP_Text>().text = ("1");
        if (stage == 6) TMP_Text_Button[number].GetComponent<TMP_Text>().text = ("1");
        if (stage == 7) TMP_Text_Button[number].GetComponent<TMP_Text>().text = ("1");
        if (stage == 8) TMP_Text_Button[number].GetComponent<TMP_Text>().text = ("1");
        if (stage == 9) TMP_Text_Button[number].GetComponent<TMP_Text>().text = ("1");
    }
    public void button4()
    {
        int number = 3;
        if (stage == 1) TMP_Text_Button[number].GetComponent<TMP_Text>().text = ("4");
        if (stage == 2)
        {
            TMP_Text_Button[number].GetComponent<TMP_Text>().text = (". . .");
            TMPComponent.text = second;
        }
        if (stage == 3)
        {
            TMP_Text_Button[number].GetComponent<TMP_Text>().text = ("4 nights");
            TMPComponent.text = fourth;
        }
        if (stage == 4) TMP_Text_Button[number].GetComponent<TMP_Text>().text = ("1");
        if (stage == 5) TMP_Text_Button[number].GetComponent<TMP_Text>().text = ("1");
        if (stage == 6) TMP_Text_Button[number].GetComponent<TMP_Text>().text = ("1");
        if (stage == 7) TMP_Text_Button[number].GetComponent<TMP_Text>().text = ("1");
        if (stage == 8) TMP_Text_Button[number].GetComponent<TMP_Text>().text = ("1");
        if (stage == 9) TMP_Text_Button[number].GetComponent<TMP_Text>().text = ("1");
    }
    public void button5()
    {
        int number = 4;
        if (stage == 1) TMP_Text_Button[number].GetComponent<TMP_Text>().text = (". . .");
        if (stage == 2)
        {
            TMP_Text_Button[number].GetComponent<TMP_Text>().text = (" . . . ");
            TMPComponent.text = second;
        }
        if (stage == 3)
        {
            TMP_Text_Button[number].GetComponent<TMP_Text>().text = ("5 nights");
            TMPComponent.text = fourth;
        }
        if (stage == 4) TMP_Text_Button[number].GetComponent<TMP_Text>().text = ("1");
        if (stage == 5) TMP_Text_Button[number].GetComponent<TMP_Text>().text = ("1");
        if (stage == 6) TMP_Text_Button[number].GetComponent<TMP_Text>().text = ("1");
        if (stage == 7) TMP_Text_Button[number].GetComponent<TMP_Text>().text = ("1");
        if (stage == 8) TMP_Text_Button[number].GetComponent<TMP_Text>().text = ("1");
        if (stage == 9) TMP_Text_Button[number].GetComponent<TMP_Text>().text = ("1");
    }
    public void button6()
    {
        int number = 5;
        if (stage == 1) TMP_Text_Button[number].GetComponent<TMP_Text>().text = (". . .");
        if (stage == 2)
        {
            TMP_Text_Button[number].GetComponent<TMP_Text>().text = (" . . .");
            TMPComponent.text = second;
        }
        if (stage == 3)
        {
            TMP_Text_Button[number].GetComponent<TMP_Text>().text = ("6 nights");
            TMPComponent.text = fourth;
        }
        if (stage == 4) TMP_Text_Button[number].GetComponent<TMP_Text>().text = ("1");
        if (stage == 5) TMP_Text_Button[number].GetComponent<TMP_Text>().text = ("1");
        if (stage == 6) TMP_Text_Button[number].GetComponent<TMP_Text>().text = ("1");
        if (stage == 7) TMP_Text_Button[number].GetComponent<TMP_Text>().text = ("1");
        if (stage == 8) TMP_Text_Button[number].GetComponent<TMP_Text>().text = ("1");
        if (stage == 9) TMP_Text_Button[number].GetComponent<TMP_Text>().text = ("1");
    }
}
