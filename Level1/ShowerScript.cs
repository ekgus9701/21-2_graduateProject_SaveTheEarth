using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowerScript : MonoBehaviour
{
    
    public void IncreaseScore()
    {
        Scoring.totalScore += 5;
        //Debug.Log(message: Scoring.totalScore);
    }
    public void DecreaseScore()
    {
        Scoring.totalScore -= 5;
        //Debug.Log(message: Scoring.totalScore);
        if(Scoring.totalScore < 0)
        {
            Scoring.totalScore = 0;
        }
       
         
    }


}
