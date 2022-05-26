using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCCube : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
      
            Debug.Log("Ãæµ¹ ok");
        if (other.tag.Equals("Untagged"))
            Destroy(other.gameObject);

    }
}
