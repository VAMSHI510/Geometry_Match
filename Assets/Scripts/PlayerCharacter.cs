using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCharacter : MonoBehaviour
{
    public GameObject[] projectiles;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            Instantiate(projectiles[0], transform.position, Quaternion.identity);
        }
        else if(Input.GetKeyDown(KeyCode.A))
        {
            Instantiate(projectiles[1], transform.position, Quaternion.identity);
        }
         else if(Input.GetKeyDown(KeyCode.D))
        {
            Instantiate(projectiles[2], transform.position, Quaternion.identity);
        } 
         /*else if(Input.GetKeyDown(KeyCode.Escape))
        {
          SceneManager.LoadScene("PlayAgain");
        }*/
    }
}
