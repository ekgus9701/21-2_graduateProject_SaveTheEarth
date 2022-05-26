using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eatcomplete : MonoBehaviour
{
    public GameObject cubet;
    public GameObject cubef;
    public GameObject food1;
    public GameObject food2;
    public GameObject food3;
    public GameObject food4;
    public GameObject food5;
    public GameObject food6;

    Audio2 Aud2;
    Audio2 Audio3;

    void Start()
    {
        Aud2 = GameObject.Find("cubet").GetComponent<Audio2>();
        Audio3 = GameObject.Find("cubef").GetComponent<Audio2>();
       
    }

    void Update()
    {
        
    }

    public void check()
    {
        Debug.Log(food1.gameObject.activeSelf);
        Debug.Log(food2.gameObject.activeSelf);
        Debug.Log(food3.gameObject.activeSelf);
        Debug.Log(food4.gameObject.activeSelf);
        Debug.Log(food5.gameObject.activeSelf);
        Debug.Log(food6.gameObject.activeSelf);
        
        if (food1.gameObject.activeSelf == false && food2.gameObject.activeSelf == false&&
            food3.gameObject.activeSelf == false && food4.gameObject.activeSelf == false&& 
            food5.gameObject.activeSelf == false && food6.gameObject.activeSelf == false)
        {
            Debug.Log(food1.gameObject.activeSelf);
            Aud2.playAudio();
        }
        else
        {
            Scoring.totalScore += 5; //다 안먹었을때 환경오염도 점수 올라감
            Audio3.playAudio();
        }
    }
}
