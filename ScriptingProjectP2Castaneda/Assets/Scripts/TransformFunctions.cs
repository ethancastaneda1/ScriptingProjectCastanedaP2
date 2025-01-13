using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformFunctions : MonoBehaviour
{
    public float movespeed = 10f;
    public float turnspeed = 50f;
    // Start is called before the first frame update
    //void Start()
    //{
        
    //}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
            transform.Translate(-Vector3.forward * movespeed *  Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.DownArrow))
            transform.Translate(Vector3.forward * movespeed * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.LeftArrow))
            transform.Rotate(Vector3.up, -turnspeed * Time.deltaTime);

        if( Input.GetKeyDown(KeyCode.RightArrow))
            transform.Rotate(Vector3.up, turnspeed * Time.deltaTime);


    }
}
