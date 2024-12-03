using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateAndFixedUpdate : MonoBehaviour
{
    // Start is called before the first frame update


    void FixedUpdate ()
    {
        
        Debug.Log("FixedUpdate time :" + Time.deltaTime);
    }

     void Update ()
    {
        Debug.Log("Update time" + Time.deltaTime);
    }














    //void Start()
    //{
        
    //}

    // Update is called once per frame
    //void ///Update()
    //{
        
    //}
}
