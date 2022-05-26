using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio_test_2 : MonoBehaviour
{
    public GameObject cube;
    public GameObject appear;
    public GameObject disappear1;
    public GameObject disappear2;
    audio_test audio_test;

    void Start()
    {
        audio_test = GameObject.Find("Cube (1)").GetComponent<audio_test>();

    }

    private void OnCollisionEnter(Collision collision)

    {
        if (collision.collider.CompareTag("Player"))
        {
            //ebug.Log("충돌 시작!");
            audio_test.playAudio();
            Destroy(cube);
            Destroy(disappear1);
            Destroy(disappear2);
            appear.SetActive(true);
        }


    }
}
