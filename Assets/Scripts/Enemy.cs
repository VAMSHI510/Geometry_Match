using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Enemy : MonoBehaviour
{
   public float speed;
   //public Score score;
    public Text EScore;
  public static int Score = 0;
  // private Text Score;
   //private int score = 0;
    
    void Awake()
    {
      EScore = GetComponent<Text>();
    }
    // Update is called once per frame
    void Update()
    {
       transform.Translate(Vector2.left * speed * Time.deltaTime);  
    }
    private void OnTriggerEnter2D(Collider2D other)
     {
       /*if(other.CompareTag("Player"))
       {
           //score.IncreaseScore(5);
           SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
           //Score.score+=10;
           Debug.Log("projectile died");
       }*/
    //if(other.tag == gameObject.tag)
      if(other.tag == gameObject.tag)
      {
          Destroy(other.gameObject);
          Destroy(gameObject);
          Score+=10;
          
          //score.IncreaseScore(5);
          //Score=Score+5;
      }
    else
    {
        //Score.score+=10;
        Debug.Log("geometry died");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }

   
    }
     /* if(other.tag == other.tag||gameObject.tag == gameObject.tag)
      {
          Destroy(other.gameObject);
          Destroy(gameObject);
          //Score.score+=10;

      }/*
      
    
    /*private void OnCollisionEnter2D(Collision2D collision)
    {
      
       if(collision.gameObject.GetComponent<projectile>() != null )
       {
         // Destroy(other.gameObject);
          Destroy(gameObject);
          //Score.score+=10;
          
          //score.IncreaseScore(5);
          //Score=Score+5;
         }
   }*/  
 }

