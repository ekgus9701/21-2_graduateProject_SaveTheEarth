using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poolSound : MonoBehaviour
{
    public AudioSource audioData;

    
    private void OnCollisionEnter(Collision collision)
    {
        audioData = GetComponent<AudioSource>();
        audioData.Play();
        Debug.Log("d");
    }
}
