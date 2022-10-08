using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimFrailejon : MonoBehaviour
{
    Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        anim.SetTrigger("BigJump");

    }
}
