using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrincessDoor : Interactable
{
    public static bool isOpen = false;

    private DialogueManager dm;

    public GameObject requiredItem;

    public int noKeyDialogue;
    public int keyDialogue;

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

    private void Update()
    {
        if (isOpen) GetComponent<BoxCollider2D>().enabled = false;
    }
}