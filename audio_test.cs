using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio_test : MonoBehaviour
{
    AudioSource audioSource;
    //  public GameObject cube;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }



    /*private void OnCollisionEnter(Collision collision)
    {

        Debug.Log("Ãæ");
        if (collision.collider.CompareTag("Player"))
        {
            Debug.Log("Ãæµ¹");
            //audioSource.Play();
            audioSource.Play();
           // Audio2.playAudio();
           // Destroy(cube);
            // die.SetActive(false);
            //die1.SetActive(false);
            Scoring.totalScore -= 5;
        }

    }*/
    public void playAudio()
    {
        audioSource.Play();

    }
}
