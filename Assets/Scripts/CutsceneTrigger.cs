using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CutsceneTrigger : MonoBehaviour
{
    public GameObject cutscene;
    public string cutsceneName;
    public string afterCutsceneEvent;
    private CutsceneManager cm;
    public bool needsRequirement;

    private void Awake()
    {
        cm = GameObject.FindGameObjectWithTag("CutsceneManager").GetComponent<CutsceneManager>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (!needsRequirement || GameManager.canViewFinalCutscene)
        {
            cm.BeginCutscene(cutscene, cutsceneName, afterCutsceneEvent);
            gameObject.SetActive(false);
        }
    }
}
