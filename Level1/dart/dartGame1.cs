using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dartGame1 : MonoBehaviour
{

    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    
    private void OnCollisionEnter(Collision collision)

    {
        Debug.Log("1");
        //Debug.Log("충돌 시작!");
        dartScore.dartTotalScore += 100;
        audioSource.Play();



    }
}
