using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManager_lv2 : MonoBehaviour
{
   
   
    public void IncreaseScore()
    {
        Scoring.totalScore += 5;
        Debug.Log(message: Scoring.totalScore);
   
    }

    public void DecreaseScore()
    {
        Scoring.totalScore -= 5;
        if (Scoring.totalScore < 0)
        {
            Scoring.totalScore = 0;
        }
        Debug.Log(message: Scoring.totalScore);

    }

    public void ToggleIncreaseScore()
    {
        if (Toggles.totalToggle < 3)
        {
            IncreaseScore();
        }
        
    }

   
}
