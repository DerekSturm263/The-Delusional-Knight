using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
using System.Linq;

public class DialogueEditor : EditorWindow
{
    [MenuItem("Window/Dialogue Editor")]
    public static void ShowWindow()
    {
        GetWindow<DialogueEditor>("Dialogue Editor");
    }

    private void AddConversation()
    {
        Debug.Log("Added new conversation.");
    }

    private void AddDialogue()
    {
        Debug.Log("Added new dialogue.");
    }

    private void OnEnable()
    {
        titleContent = new GUIContent("Dialogue Editor");
        
    }

    private void OnGUI()
    {

    }
}
