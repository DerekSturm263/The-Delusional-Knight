using System.Collections.Generic;
using UnityEngine;
using System;

public class TriggerCutscene : MonoBehaviour
{
    public List<GameObject> cutsceneObjects = new List<GameObject>();
    private List<Action> actions = new List<Action>();

    private DialogueManager dm;

    private void Awake()
    {
        CutsceneManager.Initialize();
        dm = GameObject.FindGameObjectWithTag("DialogueManager").GetComponent<DialogueManager>();

        actions.Add(() => dm.WriteDialogue(AllDialogue.firstConversation, Characters.player, Characters.witch));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        CutsceneManager.BeginCutscene(cutsceneObjects, actions);
    }
}
