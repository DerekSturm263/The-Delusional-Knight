using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : Interactable
{
    private DialogueManager dm;
    void Start()
    {
        dm = GameObject.FindObjectOfType<DialogueManager>();
    }
    protected override void Interact()
    {
        base.Interact();
        dm.WriteDialogue(AllDialogue.firstConversation, Characters.player, Characters.witch);
    }
}
