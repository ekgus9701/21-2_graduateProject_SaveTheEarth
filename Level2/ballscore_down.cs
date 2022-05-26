using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballscore_down : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.CompareTag("bullet"))
        {
            
                Scoring.totalScore -= 5;
            if (Scoring.totalScore < 0)
            {
                Scoring.totalScore = 0;
            }
        }
    }
}
