using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addForce : MonoBehaviour
{
    public float thrust;
    public Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 lastPos = this.gameObject.transform.position;
        if (lastPos != transform.position)
        {
            rb.AddForce(Vector3.forward * thrust);
            //rb.velocity = Vector3.right * thrust;
        }
    }
}
