using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
//using TMPro;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
   //private TextMeshProUGUI PScore;
   private Text PScore;
   public static int score = 0;
   private void Awake()
   {
      //score = GetComponent<TextMeshProUGUI>(); 
      PScore = GetComponent<Text>(); 
   }  
   private void Start()
   {
       RefreshUI();
   }
   public void IncreaseScore(int increment)
   {
       score += increment;
       RefreshUI();

   }
   private void RefreshUI()
   {
        PScore.text = "Score:" +score;
        //score.text = score.ToString();        
   }
}
