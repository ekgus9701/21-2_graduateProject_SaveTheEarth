using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P : MonoBehaviour
{
   // public GameObject die;
  //  public GameObject die1;
 //   public AudioSource audioSource;

    private void OnCollisionEnter(Collision collision)
    {
       // audioSource = GetComponent<AudioSource>();
        if (collision.collider.CompareTag("Player"))
        {
            //Debug.Log("Ãæµ¹");
           // audioSource.Play();
           // die.SetActive(false);
           // die1.SetActive(false);
            Scoring.totalScore -= 5;
        }

    }
  
}
