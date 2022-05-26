using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuLook2 : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    void Update()
    {
        transform.position = target.position + offset;
        transform.LookAt(target);
        transform.Rotate(180, 0, 180);
    }
}
