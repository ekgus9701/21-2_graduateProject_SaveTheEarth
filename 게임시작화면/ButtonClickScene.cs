using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClickScene : MonoBehaviour
{
    public void SceneChange() {
        SceneManager.LoadScene("Video");
    }

}
