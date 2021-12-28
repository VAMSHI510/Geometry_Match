using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreReset : MonoBehaviour
{
    public Button Playagain;
    public Button reset;
    public Button Quit;
    // Start is called before the first frame update
    void Start()
    {
        Playagain.onClick.AddListener(PlayAgain); 
        reset.onClick.AddListener(Reset);    
        //Quit.onClick.AddListener(OnQuitClick); 

    }

    // Update is called once per frame
    void Update()
    {
        
    }
      private void PlayAgain()
      {
       SceneManager.LoadScene("geometry");
      }
      private void Reset()
      {
       PlayerPrefs.DeleteAll();
      } 
      public void quit()
    {
        //if(Editor)
        //{
            if(UnityEditor.EditorApplication.isPlaying = false);
            {
        //}
        //else
        //{
            Application.Quit();
            //UnityEngine.Quit();
            Debug.Log("ne avva oops");
            }   
    }
}
