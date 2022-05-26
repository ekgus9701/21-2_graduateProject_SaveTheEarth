using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio2 : MonoBehaviour
{
    AudioSource audioSource;
  //  public GameObject cube;
    

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void playAudio()
    {
        audioSource.Play();

    } 
}
