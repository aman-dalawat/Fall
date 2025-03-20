using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class final : MonoBehaviour
{
    public Transform player;
    public Animator animator;
    
    public AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        animator.SetBool("do", false);
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    void move()
    {
        if(transform.position.x >= 2 && transform.position.y  >= 190)
{       
       audioSource.Play();
        animator.SetBool("do", true);
         transform.DOMove(new Vector3(-9,191,0),6).SetEase(Ease.InOutSine)
        .OnComplete(() =>
        {
            transform.DOMove(new Vector3(-9,0,0),20).SetEase(Ease.InOutSine);
        });
}

    }
}
