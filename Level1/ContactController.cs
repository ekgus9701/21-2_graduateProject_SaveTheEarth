using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContactController : MonoBehaviour
{
    /*private void onCollisionEnter(UnityEngine.Collision collision){
        SceneManager.LoadScene("lv1_USACityScene");
    }*/
    // Collider 컴포넌트의 is Trigger가 false인 상태로 충돌을 시작했을 때
    private void OnCollisionEnter(Collision other)

    {

        if (other.gameObject.tag=="Player")
        {
            SceneManager.LoadScene("lv1_SaladStore");
        }
        
        

    }

    
}
