using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dartGame3 : MonoBehaviour
{
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)

    {

        //Debug.Log("�浹 ����!");
        Debug.Log("3");
        dartScore.dartTotalScore += 150;
        audioSource.Play();



    }
}
