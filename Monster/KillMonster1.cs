using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillMonster1 : MonoBehaviour
{
    public GameObject Monster;
    Animator anim;
    public bool check = true;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("bullet")){
            Debug.Log("Ãæµ¹");
            anim.SetBool("isDie", false);

            //StartCoroutine(WaitForIt());
            Scoring.totalScore -= 1;
            //Monster.SetActive(false);
            Invoke("a", 2);
        }
    }
    void a()
    {
        Monster.SetActive(false);
    }
   /*Enumerator WaitForIt()
    {
        Debug.Log("Invoke");
        yield return new WaitForSeconds(2.0f);
        
    }

    /*
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ok");

        if (other.tag.Equals("bullet"))
        {
            Debug.Log("monster ok");
           
           

            Destroy(monster);
        }
        



    }*/

}
