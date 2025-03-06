using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DualAxisExxample : MonoBehaviour
{
    public float hRange;
    public float vRange;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Horizontal");
        float xPos = h * hRange;
        float yPos = v * hRange;


            transform.position = new Vector3(xPos, 0, yPos);
        Debug.Log(h.ToString("F2"));
        Debug.Log(v.ToString("F2"));
    }
}
