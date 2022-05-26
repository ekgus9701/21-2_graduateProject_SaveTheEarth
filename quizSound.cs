using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quizSound : MonoBehaviour
{
    AudioSource audioSource;
    void Start()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        audioSource = GetComponent<AudioSource>();
        if (collision.collider.CompareTag("Player"))
        {
            audioSource.Play();
        }

    }
}
