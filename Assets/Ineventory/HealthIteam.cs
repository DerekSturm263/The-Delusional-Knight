﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthIteam : MonoBehaviour
{
    public GameObject effect;
    private Transform player;

    // Start is called before the first frame update
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void Use()
    {
        Instantiate(effect, player.position, Quaternion.identity);
        Destroy(gameObject);
    }

}
