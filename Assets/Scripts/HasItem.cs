using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HasItem : Interactable
{
    public static bool metCondition;

    private DialogueManager dm;
    private Inventroy inventory;
    public GameObject IteamButton;
    public int dialogueNum;
    public bool canGet = true;

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

        Debug.Log(metCondition);

        if (metCondition && canGet)
        {
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {
                    // Item can be in inventory
                    inventory.isFull[i] = true;
                    Instantiate(IteamButton, inventory.slots[i].transform, false);
                    Inventroy.items.Add(IteamButton);
                    canGet = false;
                    break;
                }
            }

            if (dialogueNum != 0)
            {
                dm.WriteDialogue(AllDialogue.GetDialogueByID(dialogueNum), Characters.player);
            }
        }
    }
}
