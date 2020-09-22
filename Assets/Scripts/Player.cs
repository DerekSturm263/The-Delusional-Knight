using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
public class Player : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D rb;
    private Vector3 directionFacing = new Vector3(0,-1,0);
    private float speedTemp;
    private float speedDiag;

    public float speed;
    private void Start()
    {
        speedTemp = speed; speedDiag = speed / 1.33f;
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        //Draw debug line
        Debug.DrawLine(this.transform.position, this.transform.position + directionFacing, Color.green);
        //Interact
        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit2D[] hit;
            RaycastHit2D hitFinal = new RaycastHit2D();
            float lowestDistance = 99;
            hit = Physics2D.BoxCastAll(this.transform.position, new Vector2(1f, 1f), 0, new Vector2(directionFacing.x, directionFacing.y), 1.2f, 1<<8);
            foreach(RaycastHit2D hit2 in hit)
            {
                RaycastHit2D hit2Dist = Physics2D.Raycast(this.transform.position, this.transform.position - hit2.transform.position, 999, (1 << 8)+1);
                if (hit2Dist)
                {
                    if(hit.Length == 0) { hitFinal = hit2; }
                    else
                    {
                        if (hit2Dist.distance < lowestDistance)
                        {
                            hitFinal = hit2;
                            lowestDistance = hit2.distance;
                        }
                    }
                }
            }
            if (hitFinal.transform != null)
            {
                Interactable objectInteract = hitFinal.transform.GetComponent<Interactable>();
                objectInteract.UseInteract();
            }
        }
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

        //change directino facing
        animator.SetFloat("xDir", rb.velocity.x);
        animator.SetFloat("yDir", rb.velocity.y);
    }
    public void ChangeDirectionX(int xDir)
    {
        directionFacing.x = xDir;
    }
    public void ChangeDirectionY(int yDir)
    {
        directionFacing.y = yDir;
    }
}
