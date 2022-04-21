using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class play : MonoBehaviour
{
    public Button GamePlay;
    // Start is called before the first frame update
    void Start()
    {
         GamePlay.onClick.AddListener(PlayGame) ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void PlayGame()
      {
       SceneManager.LoadScene("geometry");
      }
}
