using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete : MonoBehaviour
{
    public static bool trigger;

    private void Update()
    {
        if (trigger) gameObject.SetActive(false);
    }
}
