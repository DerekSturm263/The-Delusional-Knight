using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateObjective : MonoBehaviour
{
    public string newObjective;

    public void ChangeObjective()
    {
        UIManager.objective = newObjective;
    }
}
