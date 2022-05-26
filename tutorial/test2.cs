using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test2 : MonoBehaviour
{
    public Transform d1;
    public Transform d2; 
    public Transform d3;
    public Transform s1;
    public Transform s2;
    public Transform s3;


    void OnCollisionEnter(Collision collision)
    {

        Debug.Log("Ãæµ¹2");
        d1.gameObject.SetActive(false);
        d2.gameObject.SetActive(false);
        d3.gameObject.SetActive(false);
        s1.gameObject.SetActive(true);
        s2.gameObject.SetActive(true);
        s3.gameObject.SetActive(true);

    }
}