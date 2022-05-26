using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VideoToHome : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene("lv1_HomeScene");
    }
}