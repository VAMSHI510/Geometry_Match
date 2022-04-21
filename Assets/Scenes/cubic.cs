using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubic : MonoBehaviour
{
    //public singleton singlto;
    // Start is called before the first frame update
    void Start()
    {
        //singlto = GameObject.Find("Cube").GetComponent<singleton>();
       // singlto.Oop();
       singleton.instance.Oop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
