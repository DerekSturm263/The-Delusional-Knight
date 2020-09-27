using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialDialogue : Interactable
{
    private DialogueManager dm;
    private Inventroy inventory;

    public int dialogueNum;
    public int successDialogue;
    public int successDialogueRepeat;
    public int repeatDialogue;
    public string npcName;
    public GameObject requiredItem;
    public GameObject reward;
    private bool hasSpokenTo;
    private bool content;
    public bool isKing;
    public bool isPrincess;

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
            if (isKing)
                HasItem.metCondition = true;
            else
                Delete.trigger = true;

            if (!hasSpokenTo)
            {
                dm.WriteDialogue(AllDialogue.GetDialogueByID(dialogueNum), Characters.player, Characters.CharacterByName(npcName));
                hasSpokenTo = true;
            }
            else
            {
                if (Inventroy.items.Contains(requiredItem))
                {
                    dm.WriteDialogue(AllDialogue.GetDialogueByID(successDialogue), Characters.player, Characters.CharacterByName(npcName));

                    if (requiredItem != null)
                    {
                        int index = Inventroy.items.IndexOf(requiredItem);
                        foreach (Transform t in inventory.slots[index].GetComponentsInChildren<Transform>())
                        {
                            inventory.isFull[index] = false;
                            Inventroy.items.Remove(requiredItem);
                            if (t.gameObject != inventory.slots[index])
                                Destroy(t.gameObject);
                        }

                        if (reward != null)
                        {
                            for (int i = 0; i < inventory.slots.Length; i++)
                            {
                                if (inventory.isFull[i] == false)
                                {
                                    // Item can be in inventory
                                    inventory.isFull[i] = true;
                                    Instantiate(reward, inventory.slots[i].transform, false);
                                    Inventroy.items.Add(reward);
                                    break;
                                }
                            }
                        }

                        content = true;

                        if (isKing)    PrincessDoor.isOpen = true;
                        if (isPrincess)
                        {
                            gameObject.SetActive(false);
                            GameManager.canViewFinalCutscene = true;
                        }
                    }
                }
                else
                {
                    if (!content)
                        dm.WriteDialogue(AllDialogue.GetDialogueByID(repeatDialogue), Characters.player, Characters.CharacterByName(npcName));
                    else
                        dm.WriteDialogue(AllDialogue.GetDialogueByID(successDialogueRepeat), Characters.player, Characters.CharacterByName(npcName));
                }
            }
        }
    }
}
