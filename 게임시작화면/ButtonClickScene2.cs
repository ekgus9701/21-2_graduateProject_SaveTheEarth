using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClickScene2 : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene("controllerScene");
    }
}
