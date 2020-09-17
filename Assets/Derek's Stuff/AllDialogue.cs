using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AllDialogue
{
    public static SpeechBubble firstConversation = new SpeechBubble(Characters.witch, "I see you’ve fallen right into my trap!");
    public static SpeechBubble secondConversation = new SpeechBubble(Characters.witch, "You are going to die now!");
    public static SpeechBubble thirdConversation = new SpeechBubble(Characters.player, "Not so fast!");
    public static SpeechBubble fourthConversation = new SpeechBubble(Characters.witch, "What is that supposed to mean?");

    public static void Initialize()
    {
        firstConversation.SetLines(new List<SpeechBubble> { secondConversation });
        secondConversation.SetLines(new List<SpeechBubble> { thirdConversation });
        thirdConversation.SetLines(new List<SpeechBubble> { fourthConversation });
        fourthConversation.SetLines();
    }
}
