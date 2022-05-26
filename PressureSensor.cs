using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class PressureSensor : MonoBehaviour
{
    SerialPort data_stream = new SerialPort("COM3", 9600);
    public string receivedstring;
    public int var;
    //public Transform camTr;
    public Transform camTr;
    public float moveSpeed = 20.0f;
    // Start is called before the first frame update
    public Rigidbody playerrb;
    void Start()
    {
        data_stream.Open();
        camTr = Camera.main.GetComponent<Transform>();
        playerrb.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        /*
        receivedstring = data_stream.ReadExisting();
        var = int.Parse(receivedstring);
        
        //Debug.Log(receivedstring);
        if (var >= 100)
        {
            Debug.Log(receivedstring);
            Debug.Log(camTr.rotation);
            transform.Translate(camTr.forward * moveSpeed * Time.deltaTime);
        }
        else
        {
            Debug.Log("0임요");
        }
        */
        receivedstring = data_stream.ReadExisting();
        var = int.Parse(receivedstring);

        //Debug.Log(receivedstring);
        if (var >= 1)
        {
            MoveLookAt();
            Debug.Log(receivedstring);
        }

        else
        {
            Debug.Log("0, 압력없음");
        }
    }



    void MoveLookAt()
    {
        Vector3 dir = camTr.transform.localRotation * Vector3.forward;
        //transform.localRotation = camTr.transform.localRotation;
        //transform.localRotation = new Quaternion(0, transform.localRotation.y, 0, transform.localRotation.w);
        // gameObject.transform.Translate(dir * moveSpeed * Time.deltaTime);
        playerrb.AddForce(dir * moveSpeed);
    }
}