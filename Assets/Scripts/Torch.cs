using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class Torch : Interactable
{
    public Sprite outTorch;
    public GameObject rag;

    protected override void Interact()
    {
        if (!Inventroy.items.Contains(rag))
            return;

        base.Interact();

        GetComponent<SpriteRenderer>().sprite = outTorch;
        GetComponent<ParticleSystem>().Stop();
        GetComponent<Light2D>().enabled = false;

        gameObject.layer = LayerMask.NameToLayer("Default");
    }
}