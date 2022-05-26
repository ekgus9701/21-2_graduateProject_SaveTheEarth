using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballshot : MonoBehaviour
{
    public GameObject ball;
    public GameObject dieball;
    public bool check = true;
    public AudioSource audioData;

    void Awake()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.collider.CompareTag("bullet"))
        {
            Debug.Log("충돌");
            audioData = GetComponent<AudioSource>();
            audioData.Play();

            //StartCoroutine(WaitForIt());
            // Scoring.totalScore += 5;
            //Monster.SetActive(false);
            //Invoke("a", 0.5f);

            a();
        }

        if (collision.collider.CompareTag("floor"))
        {
            Debug.Log("충돌");

            Invoke("a", 1);
        }
    }
    void a()
    {
        ball.SetActive(true);
        dieball.SetActive(false);
    }
 
}
