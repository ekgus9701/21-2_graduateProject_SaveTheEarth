using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingManager : MonoBehaviour
{
    public GameObject ball;
    GameObject[] pins;
    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        pins = GameObject.FindGameObjectsWithTag("pin");
    }

    // Update is called once per frame
    void Logs()
    {
        Debug.Log(score);
    }

    public void CountPinsDown()
    {
       
        for (int i=0; i < pins.Length; i++)
        {
            if(pins[i].transform.eulerAngles.z >5 && pins[i].transform.eulerAngles.z < 355)
            {
                score++;
                Debug.Log(score);
            }
        }

        
    }
}
