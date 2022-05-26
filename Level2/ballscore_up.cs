using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballscore_up : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.CompareTag("bullet"))
        {

            Scoring.totalScore += 5;
        }
    }
}
