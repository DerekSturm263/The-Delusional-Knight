using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disappear : MonoBehaviour
{
    private GameObject player;
    private Animator anim;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (player.transform.position.y > transform.position.y)
            FadeOut();
        else
            FadeIn();
    }

    private void FadeOut()
    {
        anim.SetBool("Exit", true);
        anim.SetBool("Enter", false);
    }

    private void FadeIn()
    {
        anim.SetBool("Enter", true);
        anim.SetBool("Exit", false);
    }
}
