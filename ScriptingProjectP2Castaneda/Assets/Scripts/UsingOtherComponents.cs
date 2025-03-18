using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingOtherComponents : MonoBehaviour
{
    public GameObject OtherGameObject;


    private AnotherScript AnotherScript;
    private YetAnotherScript yetAnotherScript;
    private BoxCollider boxCol;
    // Start is called before the first frame update
    void Awake ()
    {
        AnotherScript = GetComponent<AnotherScript>();
        yetAnotherScript = GetComponent<YetAnotherScript>();
        boxCol = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Start ()
    {
        boxCol.size = new Vector3(3,3,3);
        Debug.Log("The player's score is " + AnotherScript.playerScore);
        Debug.Log("The playuer has died " + yetAnotherScript.numberOfPlayerDeaths + " times");
    }
}
