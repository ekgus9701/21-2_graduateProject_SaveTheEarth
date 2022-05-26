using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonDelay : MonoBehaviour
{
    [SerializeField] private Button ShowScore;
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

    IEnumerator FadeFlow() {
        yield return new WaitForSeconds(30.0f);
        audioData = GetComponent<AudioSource>();
        audioData.Play();
        ShowScore.gameObject.SetActive(true);
    }
    
}
