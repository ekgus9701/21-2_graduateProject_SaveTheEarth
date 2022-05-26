using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class talksys1 : MonoBehaviour
{
    public Animator anim;

    void Start()
    {
        anim.SetBool("talk", false);
    }

    
    public void buttonpush()
    {
        anim.SetBool("talk", true);
    }
}
