using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ButtonClick : MonoBehaviour
{
    public Button Resume;
    public Button Restart;
    public Button Quit;
    // Start is called before the first frame update
    void Start()
    {
    Resume.onClick.AddListener(OnResumeClick);   
    Restart.onClick.AddListener(OnRestartClick); 
    }

    private void OnResumeClick()
    {
      SceneManager.LoadScene("geometry");
    }

    private void OnRestartClick()
    {
      SceneManager.LoadScene("geometry");
    }
    
   
}