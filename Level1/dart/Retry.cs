using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Retry : MonoBehaviour
{
    
    //public GameObject s1;
    public GameObject dart1;
    public GameObject dart2;
    public GameObject dart3;
    public GameObject dart4;
    /*public Rigidbody rb1;
    public Rigidbody rb2;
    public Rigidbody rb3;
    public Rigidbody rb4;*/
   // public bool freezeRotation;

    public void retry()
    {
        dartScore.dartTotalScore =0;

        //s1.SetActive(false);
        dart1.transform.position = new Vector3(2.371f, 1.317f, 0.248f);
        dart2.transform.position = new Vector3(2.079f, 1.317f, 0.248f);
        dart3.transform.position = new Vector3(1.772f, 1.317f, 0.248f);
        dart4.transform.position = new Vector3(1.478f, 1.317f, 0.248f);
        dart1.transform.rotation = Quaternion.Euler(0, 90, 0);
        dart2.transform.rotation = Quaternion.Euler(0, 90, 0);
        dart3.transform.rotation = Quaternion.Euler(0, 90, 0);
        dart4.transform.rotation = Quaternion.Euler(0, 90, 0);
        /*rb1 = GetComponent<Rigidbody>();
        rb2 = GetComponent<Rigidbody>();
        rb3 = GetComponent<Rigidbody>();
        rb4 = GetComponent<Rigidbody>();
        /*rb1.FreezeRotation = false;
        rb2.FreezeRotation = false;
        rb3.FreezeRotation = false;
        rb4.FreezeRotation = false;*/
       /* rb1.constraints = RigidbodyConstraints.None;
        rb2.constraints = RigidbodyConstraints.None;
        rb3.constraints = RigidbodyConstraints.None;
        rb4.constraints = RigidbodyConstraints.None;*/

    }
}
