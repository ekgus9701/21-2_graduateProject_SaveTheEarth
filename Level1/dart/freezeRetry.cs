using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class freezeRetry : MonoBehaviour
{
    public Rigidbody rb1;
    public Button retrybtn;
    public Button btn1;

    void Start()
    {
        btn1 = retrybtn.GetComponent<Button>();
    }

    void Update()
    {

        btn1.onClick.AddListener(nonefreeze);
    }
    //rb1 = GetComponent<Rigidbody>();
    public void nonefreeze()
    {
        rb1 = GetComponent<Rigidbody>();
        rb1.constraints = RigidbodyConstraints.None;
        rb1.constraints = RigidbodyConstraints.FreezeRotation;
    }
}
