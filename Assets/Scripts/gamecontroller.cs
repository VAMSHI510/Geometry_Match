
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gamecontroller : MonoBehaviour
{
     bool GameIsPaused;
    public GameObject pasueMenuUI;
    //private Button Panel;
    // Start is called before the first frame update
    public void Start()
    {
      //GameIsPaused = false;
      //pasueMenuUI.SetActive(false);
      //pasueMenuUI = GameObject.FindGameObjectWithTag("Menu");
    }
    public void update()
      {
        //Debug.Log("oops na konde");
             if(Input.GetKeyDown(KeyCode.Escape)) 
             {
               Debug.Log("ne amma oops");
                //Pause();
                GameIsPaused = !GameIsPaused;
             }
             /*else
             {
                 Resume();    
             }*/
             if(GameIsPaused)
             {
               Resume();
             //Time.timeScale = 0f;
             }
             else
             {
               Pause();
             //Time.timeScale = 1f;
             }
          }
     
     
        public void Resume()
         {
             pasueMenuUI.SetActive(false);
             //Time.timeScale = 1f;
             //GameIsPaused = false;

         }
        public void Pause()
          {
            pasueMenuUI.SetActive(true);
              //Escape.SetActive(false);
            //Time.timeScale = 0f;
     
            //GameIsPaused = true;
          }

      
}
