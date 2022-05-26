using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class badEndingdelay : MonoBehaviour
{
    
    
    public AudioSource audioData;
    // Start is called before the first frame update
    void Start()
    {
        FADE();
    }
    public void FADE()
    {
        StartCoroutine(FadeFlow());



    }

    IEnumerator FadeFlow()
    {
        yield return new WaitForSeconds(20.0f);
        SceneManager.LoadScene("BadEndingScore");


    }

}

