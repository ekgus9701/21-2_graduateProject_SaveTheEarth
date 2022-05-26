using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    float speed=100.0f;
    void Update()
    { //wasd 키로 움직임
        float upDownPosition=Input.GetAxis("vertical");
        float leftRightPosition=Input.GetAxis("Horizontal");

        upDownPosition=upDownPosition*speed*Time.deltaTime;
        leftRightPosition=leftRightPosition*speed*Time.deltaTime;
        transform.Translate (Vector3.forward*upDownPosition);
        transform.Translate (Vector3.left*leftRightPosition);

    }
    
}
