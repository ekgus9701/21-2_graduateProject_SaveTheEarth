using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dartScore : MonoBehaviour
{
    public Text pointText;
    public static int dartTotalScore;

    void Update()
    {
        int receivedPoints = dartTotalScore;
        pointText.text = receivedPoints.ToString();
    }
}
