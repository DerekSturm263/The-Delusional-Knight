using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : Interactable
{
    private Inventroy inventory;
    public GameObject IteamButton;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventroy>();
    }

    protected override void Interact()
    {
        base.Interact();

        for (int i = 0; i < inventory.slots.Length; i++)
        {
            if (inventory.isFull[i] == false)
            {
                // Item can be in inventory
                inventory.isFull[i] = true;
                Instantiate(IteamButton, inventory.slots[i].transform, false);
                Inventroy.items.Add(IteamButton);
                Destroy(gameObject);
                break;
            }
        }
    }
}
