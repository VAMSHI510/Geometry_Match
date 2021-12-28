//using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class singleton : MonoBehaviour
{
    
    public static singleton instance;
    // Start is called before the first frame update
    void Start()
    {
     Singleton();   
    }

public void Singleton()
{
    if(instance == null)
    {
        instance = this;
    }
}
     public void Oop() {
     {
      Debug.Log("ubuntu");
     }
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
