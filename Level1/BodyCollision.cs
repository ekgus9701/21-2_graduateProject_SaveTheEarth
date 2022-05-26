using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyCollision : MonoBehaviour
{
    public Transform head;
    public Transform feet;
    
    void Update()
    {
        gameObject.transform.position = new Vector3(head.position.x, feet.position.y-0.4f, head.position.z);
    }
}
