using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fish_move : MonoBehaviour
{
    public float moveSpeed = 10.0f;
    public float turnSpeed = 10.0f;

    void Update()
    {
        transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
        transform.Rotate(Vector3.forward, turnSpeed * Time.deltaTime);
    }
}
