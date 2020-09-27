using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class AIControl : MonoBehaviour
{
    
    Patrol patrol;
    AIPath aiPath;
    EnemyAI enemyAI;
    TestFOV fov;

    GameObject enemy, player;

    public bool playerSpotted;


    void Start()
    {
        patrol = GetComponent<Patrol>();
        aiPath = GetComponent<AIPath>();
        enemyAI = GetComponent<EnemyAI>();
        fov = GetComponent<TestFOV>();

        enemy = gameObject;
        player = GameObject.FindGameObjectWithTag("Player");


    }

    
    void Update()
    {
        if(playerSpotted)
        {
            enemyAI.enabled = true;
            patrol.enabled = false;
        }
        else
        {
            enemyAI.enabled = false;
            patrol.enabled = true;
        }
        if (Vector2.Distance(transform.position, player.transform.position) <= 0.75f)
        {
            player.transform.position = PlayerManager.lastCheckpoint;
            PlayerManager.grabbed = true;
        }
        else PlayerManager.grabbed = false;
    }
}
