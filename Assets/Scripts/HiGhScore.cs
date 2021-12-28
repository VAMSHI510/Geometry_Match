using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
public class HiGhScore : MonoBehaviour
{
    private int score = 0;
    public int HighScore = 0;
    //public UnityEngine.UI.Text Score;
    public TMP_Text Highscore;

    public void Awake()
    {

    }
    public void Start()
    {
     
    }
    void Update()
    {
          highscore();
         Highscore.text = "Highscore:" +PlayerPrefs.GetInt("Highscore").ToString();
    }
    public void highscore()
    {
        if(PlayerPrefs.GetInt("Score") > PlayerPrefs.GetInt("Highscore"))
        {
            int HighScore = PlayerPrefs.GetInt("Score");
             PlayerPrefs.SetInt("Highscore",HighScore);
            
        }

    }
}
