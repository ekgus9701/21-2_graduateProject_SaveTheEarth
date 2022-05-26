using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goat_collision : MonoBehaviour
{
    public AudioSource audioData;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("goat"))
        {
            audioData = GetComponent<AudioSource>();
            audioData.Play();
            SceneManager.LoadScene("sea");
        }


    }

}
