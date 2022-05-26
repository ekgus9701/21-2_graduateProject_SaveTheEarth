using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dest_1 : MonoBehaviour
{
    public int pivotPoint;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "NPC")
        {
            if(pivotPoint == 1)
            {
                pivotPoint = 0;
            }

            if (pivotPoint == 0)
            {
                this.gameObject.transform.position = new Vector3(-112.9f, -5.0f, 68.5f);
                pivotPoint = 1;
            }
        }
    }
}
