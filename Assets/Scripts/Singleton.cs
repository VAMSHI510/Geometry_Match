using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class Singleton : MonoBehaviour
{
   
   public int score = 0; 
   //public Text HighScore;
   //public int highscore = 0;
   public static Singleton instance;
   public Text Score;

     public void Awake()
     {
       single();      
     }  
      public void Start()
      {
           
        //highscore = PlayerPrefs.GetInt("highscore", 0);
        Score = GetComponent<Text>();
        //HighScore.text = "Highscore:" +highscore.ToString();
        //RefreshUI();
      }
      public void update()
      {
         //highscore();
         //HighScore = PlayerPrefs.GetInt("Highscore",0);
         //Highscore .text = "Highscore:" +score;
         //Highscore.text = "Highscore:" +HighScore.ToString();
       }
        public void single()
        {
           if(instance == null)
            {
              instance = this;
            }
        }
      
 
      public void play()
      {
       score = score+1;
       //if(highscore<score)
           PlayerPrefs.SetInt("Score",score);
        
        RefreshUI();
        //update();
      }
     /*public void highscore()
    {
        if(PlayerPrefs.GetInt("Score") > PlayerPrefs.GetInt("Highscore"))
        {
            int HighScore = PlayerPrefs.GetInt("Score");
             PlayerPrefs.SetInt("Highscore",HighScore);
            // Highscore.text = "Highscore:" +HighScore;
            
        }

    }*/

    private void RefreshUI()
   {
        Score.text = "Score:" +score;
        
        //score.text = score.ToString();        
   }
} 

        

        
   

