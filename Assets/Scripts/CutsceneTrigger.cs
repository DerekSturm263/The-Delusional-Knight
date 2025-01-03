﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneTrigger : MonoBehaviour
{
    public GameObject cutscene;
    public string cutsceneName;
    public string afterCutsceneEvent;
    private CutsceneManager cm;

    private void Awake()
    {
        cm = GameObject.FindGameObjectWithTag("CutsceneManager").GetComponent<CutsceneManager>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        cm.BeginCutscene(cutscene, cutsceneName, afterCutsceneEvent);
        gameObject.SetActive(false);
    }
}
