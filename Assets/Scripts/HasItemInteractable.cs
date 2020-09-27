using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HasItemInteractable : Interactable
{
    private DialogueManager dm;
    private Inventroy inventory;

    public int dialogueNum;
    public int alternateDialogueNum;
    public GameObject item;
    private bool hasInteractedWith;

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

        if (dm.GetIsDialoguing())
            return;

        if (item == null)
        {
            dm.WriteDialogue(AllDialogue.GetDialogueByID(dialogueNum), Characters.player);
        }
        else
        {
            if (!hasInteractedWith)
            {
                dm.WriteDialogue(AllDialogue.GetDialogueByID(dialogueNum), Characters.player);
                dm.SetEndOfDialogue(() =>
                {
                    for (int i = 0; i < inventory.slots.Length; i++)
                    {
                        if (inventory.isFull[i] == false)
                        {
                            // Item can be in inventory
                            inventory.isFull[i] = true;
                            Instantiate(item, inventory.slots[i].transform, false);
                            Inventroy.items.Add(item);
                            break;
                        }
                    }
                });
                hasInteractedWith = true;
            }
            else
            {
                dm.WriteDialogue(AllDialogue.GetDialogueByID(alternateDialogueNum), Characters.player);
            }
        }
    }
}
