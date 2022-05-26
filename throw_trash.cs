using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throw_trash : MonoBehaviour{


    public float moveSpeed = 0;
    public float turnSpeed = 0;
    
    

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
        transform.Rotate(Vector3.forward, turnSpeed * Time.deltaTime);
    }
}
