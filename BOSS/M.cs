using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M : MonoBehaviour
{
    //public GameObject die;
    //public GameObject die1;
   // public AudioSource audioSource;
    //public AudioSource audioSource = gameObject.GetComponent<AudioSource>();
   // public GameObject cube;
    //Audio2 Audio2;

    void Start()
    {
        //Audio2 = GameObject.Find("M").GetComponent<Audio2>();

    }
    private void OnCollisionEnter(Collision collision)
    {
        
        //Debug.Log("Ãæ");
        if (collision.collider.CompareTag("Player"))
        {
            //Debug.Log("Ãæµ¹");
            //audioSource.Play();
           // Audio2.playAudio();
           // Destroy(cube);
            // die.SetActive(false);
            //die1.SetActive(false);
            Scoring.totalScore += 5;
        }

    }


  
}
