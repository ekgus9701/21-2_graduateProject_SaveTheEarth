using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SouvenirManager : MonoBehaviour
{
    public GameObject souvenir;
    public GameObject arrow;
    public GameObject cube;

    public AudioClip[] intro_music;
    AudioSource soundSource;

   
    private void OnCollisionEnter(Collision other)
    {
        //audio = GetComponent<AudioSource>();
        soundSource = GetComponent<AudioSource>();
        Debug.Log("ok");
       

        if (other.gameObject.tag=="shell")
        {
            Debug.Log("plus ok");
            Scoring.totalScore -= 10;
            Debug.Log(message: Scoring.totalScore);

            Destroy(other.gameObject);
            Destroy(souvenir);

            StartCoroutine("Playlist");
            //StartCoroutine("Playlist3");
            arrow.gameObject.SetActive(true);
            cube.gameObject.SetActive(true);

        }
        

        if (other.gameObject.tag=="nothing")
        {
            Scoring.totalScore += 10;
            Destroy(other.gameObject);
            Destroy(souvenir);
            StartCoroutine("Playlist2");
            //StartCoroutine("Playlist3");
            arrow.gameObject.SetActive(true);
            cube.gameObject.SetActive(true);
        }

    }

    IEnumerator Playlist()
    {
        soundSource.clip = intro_music[0];
        soundSource.Play();
        while (true)
        {
            yield return new WaitForSeconds(0.5f);
            if (!soundSource.isPlaying)
            {
                soundSource.clip = intro_music[1];
                soundSource.Play();

                
                soundSource.loop = false;
                break;
            }
        }
    }

    IEnumerator Playlist2()
    {
        soundSource.clip = intro_music[2];
        soundSource.Play();
        while (true)
        {
            yield return new WaitForSeconds(0.5f);
            if (!soundSource.isPlaying)
            {
                soundSource.clip = intro_music[1];
                soundSource.Play();
               
                soundSource.loop = false;
                break;
            }
        }
    }

    /*IEnumerator Playlist3()
    {
        yield return new WaitForSeconds(0.5f);
        soundSource.clip = intro_music[3];
        soundSource.Play();
    }*/

 }
