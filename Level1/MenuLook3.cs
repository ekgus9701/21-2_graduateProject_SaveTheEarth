using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuLook3 : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public GameObject image;

    void Update()
    {
        transform.position = target.position + offset;
        transform.LookAt(target);
        transform.Rotate(180, 0, 180);

        Invoke("nosee", 2.0f);
    }

    void nosee()
    {
        image.gameObject.SetActive(false);
    }
}
