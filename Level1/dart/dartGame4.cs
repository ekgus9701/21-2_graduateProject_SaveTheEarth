using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dartGame4 : MonoBehaviour
{
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)

    {

        //Debug.Log("충돌 시작!");
        Debug.Log("4");
        dartScore.dartTotalScore += 175;
        audioSource.Play();



    }
}
