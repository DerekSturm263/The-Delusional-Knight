using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrincessDoor : Interactable
{

    private DialogueManager dm;
    private Inventroy inventory;

    public GameObject requiredItem;

    public int noKeyDialogue;
    public int keyDialogue;

    private void Awake()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventroy>();
    }

    void Start()
    {
        dm = GameObject.FindObjectOfType<DialogueManager>();
    }

    protected override void Interact()
    {
        base.Interact();

        if (!dm.GetIsDialoguing())
        {
            if (Inventroy.items.Contains(requiredItem))
            {
                dm.WriteDialogue(AllDialogue.GetDialogueByID(keyDialogue), Characters.player);
            }
            else
            {
                dm.WriteDialogue(AllDialogue.GetDialogueByID(noKeyDialogue), Characters.player);
            }
        }
    }
}