using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallDown : MonoBehaviour
{
    public GameObject target;
    public AudioSource audioData;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.tag);
        Debug.Log("a");
        if (collision.gameObject.CompareTag("wrong"))
        {
            Debug.Log("d");
            target.gameObject.SetActive(true);
            audioData = GetComponent<AudioSource>();
            audioData.Play();
            Invoke("returns", 6f);   
        }

    }

    void returns()
    {
        target.gameObject.SetActive(false);
    }
}
