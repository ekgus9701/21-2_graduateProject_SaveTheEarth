using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ContactController3 : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)

    {

        Debug.Log("충돌 시작!");
        SceneManager.LoadScene("lv1_USACityScene2");


    }

    
}
