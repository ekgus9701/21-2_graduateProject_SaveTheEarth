using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Darts : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ok");

        if (other.tag.Equals("plus"))
        {
            Debug.Log("plus ok");
        }
    }
}
