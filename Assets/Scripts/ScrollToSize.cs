using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[ExecuteAlways]
public class ScrollToSize : MonoBehaviour
{
    private void Awake()
    {
        GetComponent<Scrollbar>().SetValueWithoutNotify(1f);
    }
}
