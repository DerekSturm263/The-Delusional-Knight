using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : Interactable
{
    private DialogueManager dm;
    private Inventroy inventory;
    private GameObject player;

    public int dialogueNum;
    public int alternateDialogueNum;
    public string npcName;
    public GameObject item;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
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
                if (!Inventroy.items.Contains(item))
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
                }
                else
                {
                    dm.WriteDialogue(AllDialogue.GetDialogueByID(alternateDialogueNum), Characters.player, Characters.CharacterByName(npcName));
                }
            }
        }
    }
}
