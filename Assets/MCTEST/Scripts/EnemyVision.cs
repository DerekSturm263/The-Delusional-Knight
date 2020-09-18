using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVision : MonoBehaviour
{
    public GameObject player, enemy;

    public float fieldOfViewAngle = 110f;
    public bool playerInSight, playerInRange;
 


    public float speed = 30f;

    void Start()
    {
        enemy = gameObject;
        player = GameObject.FindGameObjectWithTag("Player");
        
    }
    
    void Update()
    {
       //Math Stuffs
        Vector2 playerPosition = player.transform.position;
        Vector2 EnemyPosition = enemy.transform.position;

        //Logic Checks
        
        if (Vector2.Angle(transform.up, playerPosition - EnemyPosition) < fieldOfViewAngle)
        {
            playerInSight = true;
        }
        else playerInSight = false;
        if (Vector2.Distance(transform.position, playerPosition) <= 6 && playerInSight)
        {
            Rotation();
        }

    }

    private void Rotation()
    {
        Vector2 direction = player.transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, speed * Time.deltaTime);
    }
}
