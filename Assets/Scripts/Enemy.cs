

using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Enemy : MonoBehaviour
{
     public float speed;
    // public Singleton scoreText;
    
    void Awake()
    {
       //scoreText= GameObject.Find("Score").GetComponent<Singleton>(); // finding the GameObject Score (which is there in this project) By using the script called Singleton;
        //Singleton.instance.play();
    }
     private void Start()
     {
      Singleton.instance.play();
       
     }
    // Update is called once per frame
     void Update()
     {
       transform.Translate(Vector2.left * speed * Time.deltaTime); 
      

     }
     private void OnTriggerEnter2D(Collider2D other)
     {
       if(other.CompareTag("Man"))
       {
           Destroy(gameObject);
           SceneManager.LoadScene("PlayAgain");
           Debug.Log("projectile died");
       }
        if(gameObject.tag == other.tag)
        {
           
        Destroy(other.gameObject);
        Destroy(gameObject);
        //scoreText.play();

        }
        else
        {
          Destroy(other.gameObject);
          Destroy(gameObject);
          Debug.Log("geometry died");
          SceneManager.LoadScene("PlayAgain");
    }
  }
}     

