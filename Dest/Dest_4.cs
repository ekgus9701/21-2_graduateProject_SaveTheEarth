using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dest_4 : MonoBehaviour
{

    public int pivotPoint;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "NPC")
        {
            if (pivotPoint == 1)
            {
                pivotPoint = 0;
            }

            if (pivotPoint == 0)
            {
                this.gameObject.transform.position = new Vector3(98.02f, 0.3f, 3.1f);
                pivotPoint = 1;
            }
        }
    }
}
