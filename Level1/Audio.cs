using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    
    public GameObject cube;
    Audio2 Audio2;

    void Start()
    {
        Audio2 = GameObject.Find("Cube (1)").GetComponent<Audio2>();
        
    }

    private void OnCollisionEnter(Collision collision)

    {

        Debug.Log("충돌 시작!");
        Audio2.playAudio();
        Destroy(cube);


    }
}
