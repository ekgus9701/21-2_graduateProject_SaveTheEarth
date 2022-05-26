using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenechange : MonoBehaviour
{
    public void change()
    {
        SceneManager.LoadScene("localhome");
    }
}
