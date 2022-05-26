using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalScore : MonoBehaviour
{

    [SerializeField] private Image pass;
    [SerializeField] private Image fail;

    public void CheckScore()
    {
        if (Scoring.totalScore >= 20)
        {
            pass.gameObject.SetActive(true);
        }
        else
        {
            fail.gameObject.SetActive(true);
        }
    }   

    
}
