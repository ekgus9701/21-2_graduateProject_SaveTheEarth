using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCDest : MonoBehaviour
{
    public int pivotPoint;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "NPC")
        {

            if (pivotPoint == 2)
            {
                this.gameObject.transform.position = new Vector3(-1.109f, 0.0f, 3.306f);
                pivotPoint = 3;
            }

            if(pivotPoint == 1)
            {
                this.gameObject.transform.position = new Vector3(-2.426f, 00.0f, 3.123f);
                pivotPoint = 2;
            }

            if (pivotPoint == 0)
            {
                this.gameObject.transform.position = new Vector3(-2.853f, 0.0f, 3.225f);
                pivotPoint = 1;
            }
        }
    }
}
