using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : Interactable
{
    private DialogueManager dm;
    private Inventroy inventory;

    public int dialogueNum;
    public int alternateDialogueNum;
    public string npcName;
    public GameObject item;
    private bool hasSpokenTo;

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
            if (item == null)
            {
                dm.WriteDialogue(AllDialogue.GetDialogueByID(dialogueNum), Characters.player, Characters.CharacterByName(npcName));
            }
            else
            {
                if (!hasSpokenTo)
                {
                    dm.WriteDialogue(AllDialogue.GetDialogueByID(dialogueNum), Characters.player, Characters.CharacterByName(npcName));
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
                    hasSpokenTo = true;
                }
                else
                {
                    dm.WriteDialogue(AllDialogue.GetDialogueByID(alternateDialogueNum), Characters.player, Characters.CharacterByName(npcName));
                }
            }
        }
    }
}
