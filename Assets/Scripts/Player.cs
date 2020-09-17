using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D rb;
    public float speed;

    float speedTemp;
    float speedDiag;
    private void Start()
    {
        speedTemp = speed; speedDiag = speed / 1.33f;
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
    }

    private void FixedUpdate()
    {
        float MoveX = Input.GetAxisRaw("Horizontal");
        float MoveY = Input.GetAxisRaw("Vertical");

        Vector2 velocity;
        velocity.x = MoveX * speed;
        velocity.y = MoveY * speed;

        //Make diagnal speed lower 
        if(velocity.x != 0 && velocity.y != 0)
        {
            speed = speedDiag;
        }
        else { speed = speedTemp; }

       rb.velocity = velocity;
    }
}
