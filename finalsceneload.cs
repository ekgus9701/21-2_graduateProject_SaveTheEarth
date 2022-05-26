using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finalsceneload : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;
    private void OnCollisionEnter(Collision collision)

    {

        Debug.Log("충돌 시작!");
        source.PlayOneShot(clip);
        Invoke("LoadScenes", 4.0f);
        


    }

    private void LoadScenes()
    {
        SceneManager.LoadScene("happyend");
    }
}
