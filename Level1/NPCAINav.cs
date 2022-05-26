using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class NPCAINav : MonoBehaviour
{
    public Transform target;
    public float speed;
    public Transform finish;
   [SerializeField] private Image arrow;
    //public Sprite dinner_menu;
    

    Animator anim;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        transform.LookAt(target);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "dest")
        {
            this.gameObject.transform.position = new Vector3(-0.956f, 0.176f, 3.182f);
            anim.SetBool("isWalk", false);
            transform.LookAt(finish);
            Destroy(gameObject);
            Destroy(target.gameObject);
            Destroy(finish.gameObject);
            arrow.gameObject.SetActive(true);
        }
    }
}
