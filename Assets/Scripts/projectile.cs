
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class projectile : MonoBehaviour
{
   public float speed;
   //public Score score;

    // Update is called once per frame
    void Update()
    {
     transform.Translate(Vector2.right * speed * Time.deltaTime);   
    }
    /*private void OnTriggerEnter2D(Collider2D other)
    {
           //score.IncreaseScore(5);
    //if(other.tag == gameObject.tag)
      if(other.tag == gameObject.tag)
      {
       Destroy(other.gameObject);
       Destroy(gameObject);
      }
       else
       {
           //Destroy(other.gameObject);
           //Destroy(gameObject);
       }

         //score.IncreaseScore(5);
      }*/
    }

