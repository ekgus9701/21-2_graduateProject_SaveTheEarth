using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ScoreManager : MonoBehaviour
{
   
    public TextMeshProUGUI pointText;
    
    //private int resource;
    // public int score;
    void Start()
    {
        pointText = gameObject.GetComponent<TextMeshProUGUI>();
        //Scoring.totalScore += 25;
        //resource = 500;
    }
    
    void Update()
    {
        //pointText.text = resource.ToString();
        int receivedPoints = Scoring.totalScore;
        //Debug.Log(receivedPoints);
        
        pointText.text = receivedPoints.ToString();
        
        

    }

    public void IncreaseScore()
    {
        Scoring.totalScore += 5;
        Debug.Log(message: Scoring.totalScore);
        pointText.text = Scoring.totalScore.ToString();
    }

    public void DecreaseScore()
    {
        Scoring.totalScore -= 5;
        if (Scoring.totalScore < 0)
        {
            Scoring.totalScore = 0;
        }
        Debug.Log(message: Scoring.totalScore);
        pointText.text = Scoring.totalScore.ToString();
    }

    /*
    public void ToggleIncreaseScore()
    {
        if (Toggles.totalToggle < 3)
        {
            IncreaseScore();
        }
        
    }

    public void GetScore()
    {
        int receivedPoints = Scoring.totalScore;
        if(receivedPoints < 0)
        {
            pointText.text = "0";

        }
        else {
            pointText.text = receivedPoints.ToString();
        }

        //pointText.text = receivedPoints.ToString();
        
    }*/
}
