using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class object_collision : MonoBehaviour
{

    public AudioSource audioData;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("trash"))
        {
            //Debug.Log("cnde");
            audioData = GetComponent<AudioSource>();
            audioData.Play();
            SceneManager.LoadScene("fire_scene");
        }


    }
}
