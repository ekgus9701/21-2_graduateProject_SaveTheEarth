using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test3 : MonoBehaviour
{
    public Transform s1;
    public Transform s2;
    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "tutorial")
        {
            Debug.Log("Ãæµ¹Çß»ï");
            //SceneManager.LoadScene("StartScene");
            s1.gameObject.SetActive(true);
            s2.gameObject.SetActive(true);

        }
    }
}
