using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controllerToTutorial : MonoBehaviour
{
    void Start()
    {
        //Start the coroutine we define below named ChangeAfter2SecondsCoroutine().
        StartCoroutine(ChangeAfter2SecondsCoroutine());
    }

    IEnumerator ChangeAfter2SecondsCoroutine()
    {
       

        
        yield return new WaitForSeconds(20);

       
        SceneManager.LoadScene("tutorialScene");
    }

}
