/***********************************
 * Ryan Chen
 * March 4th
 * Event Handler, makes events progress
 * ********************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    public string Level = "";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void NextSceness()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Settingss()
    {
        SceneManager.LoadScene(Level);
    }
    public void GETSCAMMED()
    {
        Application.Quit();
    }    
}
