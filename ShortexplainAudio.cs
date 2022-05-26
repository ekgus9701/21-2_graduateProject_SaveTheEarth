using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShortexplainAudio : MonoBehaviour
{

    public AudioClip[] checkAndexplain;
    AudioSource soundSource;


    public void pplay_audio()
    {

        soundSource = GetComponent<AudioSource>();  

        StartCoroutine("Playlist");
       

    }

    IEnumerator Playlist()
    {
        soundSource.clip = checkAndexplain[0];
        soundSource.Play();
        while (true)
        {
            yield return new WaitForSeconds(0.0f);
            if (!soundSource.isPlaying)
            {
                soundSource.clip = checkAndexplain[1];
                soundSource.Play();


                soundSource.loop = false;
                break;
            }
        }
    }

}
