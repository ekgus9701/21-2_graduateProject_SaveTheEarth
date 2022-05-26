using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[RequireComponent(typeof(AudioSource))]
public class SuitcaseManager : MonoBehaviour
{
    public GameObject cubet;
    //public GameObject cubef;
   Audio2 Audio2;
   // Audio2 Audio3;

    void Start()
    {
        Audio2 = GameObject.Find("cubet").GetComponent<Audio2>();
        //Audio3 = GameObject.Find("cubef").GetComponent<Audio2>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ok");
        
        if (other.tag.Equals("plus"))
        {
            Debug.Log("plus ok");
            Scoring.totalScore -= 4;
            if (Scoring.totalScore < 0)
            {
                Scoring.totalScore = 0;
            }
            Debug.Log(message: Scoring.totalScore);
           Audio2.playAudio();
           Destroy(cubet);
            Destroy(other.gameObject);
        }


        if (other.tag.Equals("nothing"))
        {
           // Audio3.playAudio();
           // Destroy(cubef);
            Destroy(other.gameObject);
        }

    }
}
