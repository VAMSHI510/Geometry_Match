using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class Pasmenu : MonoBehaviour
{
 
    public GameObject PauseScreen;
    public GameObject PauseButton;
 
    bool GamePaused;
 
 
    // Start is called before the first frame update
    void Start()
    {
        GamePaused = false;
    }
 
    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKeyDown(KeyCode.Escape))
        //{
        if (GamePaused)
        {
            Time.timeScale = 0;
        }
        else
        {
           Time.timeScale = 1;
        }
    }
 
    public void PauseGame()
    {
        GamePaused = true;
        PauseScreen.SetActive(true);
        PauseButton.SetActive(false);
    }
 
    public void ResumeGame()
    {
        GamePaused = false;
        PauseScreen.SetActive(false);
        PauseButton.SetActive(true);
    }
    public void Quit()
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
