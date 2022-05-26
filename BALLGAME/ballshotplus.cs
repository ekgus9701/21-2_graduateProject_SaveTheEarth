using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballshotplus : MonoBehaviour
{
    public GameObject ball;
    public GameObject dieball;
    public bool check = true;

    void Awake()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("bullet"))
        {
            Debug.Log("충돌");

            //StartCoroutine(WaitForIt());

            //Monster.SetActive(false);
            // a();
            ball.SetActive(true);
            dieball.SetActive(false);
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
