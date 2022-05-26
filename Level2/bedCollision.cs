using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bedCollision : MonoBehaviour
{
  // public AudioSource audioSource;
    //  public GameObject cube;
    public GameObject cube;
    //Audio2 Audio2;
    AudioSource audioSource;
    [SerializeField] private Button ShowScore;

    void Start()
    {
        // audioSource = GetComponent<AudioSource>();
        audioSource = GameObject.Find("Cube (2)").GetComponent<AudioSource>();
    }
    public void playAudio()
    {
        audioSource.Play();

    }

    public Image Panel;
    float time = 0f;
    float F_time = 1.0f;

    private void OnCollisionEnter(Collision collision)

    {

        Fade();

    }

    public void Fade()
    {
        StartCoroutine(FadeFlow());
       

    }
    IEnumerator FadeFlow()
    {
        Panel.gameObject.SetActive(true);
        time = 0f;
        Color alpha = Panel.color;
        while (alpha.a < 1f)
        {
            time += Time.deltaTime / F_time;
            alpha.a = Mathf.Lerp(0, 1, time);
            Panel.color = alpha;
            yield return null;
        }
        time = 0f;

        playAudio();
        yield return new WaitForSeconds(9.0f);
        


        while (alpha.a > 0f)
        {
            time += Time.deltaTime / F_time;
            alpha.a = Mathf.Lerp(1, 0, time);
            Panel.color = alpha;
            yield return null;
        }
        Panel.gameObject.SetActive(false);
        Destroy(cube);
        ShowScore.gameObject.SetActive(true);
        yield return null;
       
    }

    
}
