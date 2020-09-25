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

    public Sprite secondSprite;

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
                if (!Inventroy.items.Contains(requiredItem) && requiredItem != null)
                {
                    dm.WriteDialogue(AllDialogue.GetDialogueByID(alternateDialogueNum), Characters.player);
                }
                else
                {
                    if (requiredItem != null)
                    {
                        int index = Inventroy.items.IndexOf(requiredItem);
                        foreach (Transform t in inventory.slots[index].GetComponentsInChildren<Transform>())
                        {
                            if (t.gameObject != inventory.slots[index])
                                Destroy(t.gameObject);
                        }
                    }

                    if (dialogueNum != -1)
                    {
                        dm.WriteDialogue(AllDialogue.GetDialogueByID(dialogueNum), Characters.player);
                    }

                    GetComponent<SpriteRenderer>().sprite = secondSprite;
                    hasUsed = true;
                    GetComponent<BoxCollider2D>().enabled = false;
                }
            }
        }
    }
}
