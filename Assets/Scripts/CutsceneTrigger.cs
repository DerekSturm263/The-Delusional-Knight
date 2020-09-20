using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneTrigger : MonoBehaviour
{
    public GameObject cutscene;

    private void Awake()
    {
        CutsceneManager.Initialize();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        CutsceneManager.BeginCutscene(cutscene);
    }
}
