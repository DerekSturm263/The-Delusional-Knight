﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    protected virtual void Interact()
    {

    }

    public void UseInteract()
    {
        if (UIManager.isInventoryOpen)
            FindObjectOfType<UIManager>().CloseInventory();

        Interact();
    }
}
