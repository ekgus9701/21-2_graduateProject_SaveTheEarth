using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goToSouvenirShop : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)

    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("충돌 시작!");
            SceneManager.LoadScene("SouvenirShop");
        }

    }
}
