using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Used for doors.
public class ItemInteractable : Interactable
{
    private DialogueManager dm;
    private Inventroy inventory;

    public GameObject requiredItem;
    public bool itemDisappears;

    private bool hasUsed;

    public int dialogueNum;
    public int alternateDialogueNum;

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
            if (!hasUsed)
            {
                if (!Inventroy.items.Contains(requiredItem))
                {
                    dm.WriteDialogue(AllDialogue.GetDialogueByID(alternateDialogueNum), Characters.player);
                }
                else
                {
                    if (itemDisappears)
                    {
                        Inventroy.items.Remove(requiredItem);

                        for (int i = 0; i < inventory.slots.Length; i++)
                        {
                            if (inventory.slots[i].gameObject == requiredItem)
                                Debug.Log(inventory.slots[i].gameObject.name);
                        }
                    }

                    dm.WriteDialogue(AllDialogue.GetDialogueByID(dialogueNum), Characters.player);
                    hasUsed = true;
                    GetComponent<BoxCollider2D>().enabled = false;
                }
            }
        }
    }
}
