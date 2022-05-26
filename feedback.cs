using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class feedback : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    void Update()
    {
        transform.position = target.position + offset;
        transform.LookAt(target);
        transform.Rotate(180, 0, 180);
        //Quaternion rotation = Quaternion.LookRotation(re)
    }
}
