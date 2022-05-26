using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goToYoutube : MonoBehaviour
{
    public void go()
    {
        Invoke("seeYoutube", 4.5f);
    }
    

    public void seeYoutube()
    {
        SceneManager.LoadScene("Youtube");
        
    }
}
