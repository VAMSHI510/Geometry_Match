using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float startTimeBtwSpawn;
   // public Score score;
    
    private float timeBtwSpawn;
    
    public GameObject[] enemies;

   // Update is called once per frame
    void Update()
    {
      if(timeBtwSpawn<=0)
      {
          int rand = Random.Range(0,enemies.Length);
          Instantiate(enemies[rand], transform.position, Quaternion.identity);
          //Instantiate(enemies[rand], transform.position,transform.rotation);
          timeBtwSpawn = startTimeBtwSpawn;
      }
       
       else
       {
          timeBtwSpawn -= Time.deltaTime;
       }
        
     
   }
}
