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
    public string first = "Game has Started, click the first box to continue";
    public string second = "loser";
    public string third = "bad";
    public string fourth = "child";
    public string fifth = "literal loser";
    public string sixth = "actual loser";
    public string seventh = "nobody likes you";
    public string eighth = "you're sad";
    public string ninth = "bad.";
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
            //set all textmeshpros to TMP_Text_Button.
            TMP_Text_Button[i - 1] = texts[i - 1].GetComponent<TextMeshPro>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(TMPComponent.text == "")
        {
            TMPComponent.text = first;
        }
        else if(TMPComponent.text == first)
        {
            stage += 1;
        }
        else if (TMPComponent.text == second)
        {
            stage += 1;
        }
        else if (TMPComponent.text == third)
        {
            stage += 1;
        }
        else if (TMPComponent.text == fourth)
        {
            stage += 1;
        }
        else if (TMPComponent.text == fifth)
        {
            stage += 1;
        }
        else if (TMPComponent.text == sixth)
        {
            stage += 1;
        }
        else if (TMPComponent.text == seventh)
        {
            stage += 1;
        }
        else if (TMPComponent.text == eighth)
        {
            stage += 1;
        }
        else if (TMPComponent.text == ninth)
        {
            stage += 1;
        }
    }
    public void button1()
    {
        if (stage == 1) this.GetComponent<TextMeshPro>().text = ("1");
        if (stage == 2) this.GetComponent<TextMeshPro>().text = ("1");
        if (stage == 3) this.GetComponent<TextMeshPro>().text = ("1");
        if (stage == 4) this.GetComponent<TextMeshPro>().text = ("1");
        if (stage == 5) this.GetComponent<TextMeshPro>().text = ("1");
        if (stage == 6) this.GetComponent<TextMeshPro>().text = ("1");
        if (stage == 7) this.GetComponent<TextMeshPro>().text = ("1");
        if (stage == 8) this.GetComponent<TextMeshPro>().text = ("1");
        if (stage == 9) this.GetComponent<TextMeshPro>().text = ("1");
    }
    public void button2()
    {
        if (stage == 1) this.GetComponent<TextMeshPro>().text = ("1");
        if (stage == 2) this.GetComponent<TextMeshPro>().text = ("1");
        if (stage == 3) this.GetComponent<TextMeshPro>().text = ("1");
        if (stage == 4) this.GetComponent<TextMeshPro>().text = ("1");
        if (stage == 5) this.GetComponent<TextMeshPro>().text = ("1");
        if (stage == 6) this.GetComponent<TextMeshPro>().text = ("1");
        if (stage == 7) this.GetComponent<TextMeshPro>().text = ("1");
        if (stage == 8) this.GetComponent<TextMeshPro>().text = ("1");
        if (stage == 9) this.GetComponent<TextMeshPro>().text = ("1");
    }
    public void button3()
    {
        if (stage == 1) this.GetComponent<TextMeshPro>().text = ("1");
        if (stage == 2) this.GetComponent<TextMeshPro>().text = ("1");
        if (stage == 3) this.GetComponent<TextMeshPro>().text = ("1");
        if (stage == 4) this.GetComponent<TextMeshPro>().text = ("1");
        if (stage == 5) this.GetComponent<TextMeshPro>().text = ("1");
        if (stage == 6) this.GetComponent<TextMeshPro>().text = ("1");
        if (stage == 7) this.GetComponent<TextMeshPro>().text = ("1");
        if (stage == 8) this.GetComponent<TextMeshPro>().text = ("1");
        if (stage == 9) this.GetComponent<TextMeshPro>().text = ("1");
    }
    public void button4()
    {
        if (stage == 1) this.GetComponent<TextMeshPro>().text = ("1");
        if (stage == 2) this.GetComponent<TextMeshPro>().text = ("1");
        if (stage == 3) this.GetComponent<TextMeshPro>().text = ("1");
        if (stage == 4) this.GetComponent<TextMeshPro>().text = ("1");
        if (stage == 5) this.GetComponent<TextMeshPro>().text = ("1");
        if (stage == 6) this.GetComponent<TextMeshPro>().text = ("1");
        if (stage == 7) this.GetComponent<TextMeshPro>().text = ("1");
        if (stage == 8) this.GetComponent<TextMeshPro>().text = ("1");
        if (stage == 9) this.GetComponent<TextMeshPro>().text = ("1");
    }
    public void button5()
    {
        if (stage == 1) this.GetComponent<TextMeshPro>().text = ("1");
        if (stage == 2) this.GetComponent<TextMeshPro>().text = ("1");
        if (stage == 3) this.GetComponent<TextMeshPro>().text = ("1");
        if (stage == 4) this.GetComponent<TextMeshPro>().text = ("1");
        if (stage == 5) this.GetComponent<TextMeshPro>().text = ("1");
        if (stage == 6) this.GetComponent<TextMeshPro>().text = ("1");
        if (stage == 7) this.GetComponent<TextMeshPro>().text = ("1");
        if (stage == 8) this.GetComponent<TextMeshPro>().text = ("1");
        if (stage == 9) this.GetComponent<TextMeshPro>().text = ("1");
    }
    public void button6()
    {
        if (stage == 1) this.GetComponent<TextMeshPro>().text = ("1");
        if (stage == 2) this.GetComponent<TextMeshPro>().text = ("1");
        if (stage == 3) this.GetComponent<TextMeshPro>().text = ("1");
        if (stage == 4) this.GetComponent<TextMeshPro>().text = ("1");
        if (stage == 5) this.GetComponent<TextMeshPro>().text = ("1");
        if (stage == 6) this.GetComponent<TextMeshPro>().text = ("1");
        if (stage == 7) this.GetComponent<TextMeshPro>().text = ("1");
        if (stage == 8) this.GetComponent<TextMeshPro>().text = ("1");
        if (stage == 9) this.GetComponent<TextMeshPro>().text = ("1");
    }
}
