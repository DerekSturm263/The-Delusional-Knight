using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class AIControl : MonoBehaviour
{
    
    Patrol patrol;
    AIPath aiPath;
    EnemyAI enemyAI;

    GameObject enemy, player;


    void Start()
    {
        patrol = GetComponent<Patrol>();
        aiPath = GetComponent<AIPath>();
        enemyAI = GetComponent<EnemyAI>();

        enemy = gameObject;
        player = GameObject.FindGameObjectWithTag("Player");


    }

    
    void Update()
    {
        
    }
}
