using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dartGame : MonoBehaviour
{
   // public float thrust = 1.0f;
    public Rigidbody rd;
    //public Button retrybtn;
    //public Button btn1;
    

    private void OnCollisionEnter(Collision collision)

    {

        Debug.Log("충돌 시작!");
        
        rd.constraints = RigidbodyConstraints.FreezeAll;
        


    }
    //public Rigidbody rb1;

    //rb1 = GetComponent<Rigidbody>();
    /*public void nonefreeze()
    {
        //rb1 = GetComponent<Rigidbody>();
        rd.constraints = RigidbodyConstraints.None;
    }*/
}
