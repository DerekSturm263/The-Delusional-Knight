using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AllDialogue
{
    public static SpeechBubble firstConversation = new SpeechBubble(Characters.witch, "I see you’ve fallen right into my trap!");
    public static SpeechBubble secondConversation = new SpeechBubble(Characters.witch, "You're going to die now!");
    public static SpeechBubble thirdConversation = new SpeechBubble(Characters.player, "Not so fast!");
    public static SpeechBubble fourthConversation = new SpeechBubble(Characters.witch, "What is that supposed to mean?");
    public static SpeechBubble responseAnswers = new SpeechBubble(Characters.player, new List<string> { "You'll see!", "I don't know...", "What's behind you?" });
    public static SpeechBubble response1 = new SpeechBubble(Characters.player, "You'll see! I know what you did to me that night!");
    public static SpeechBubble response2 = new SpeechBubble(Characters.player, "I don't know. I was kinda hoping you'd be too scared to ask.");
    public static SpeechBubble response3 = new SpeechBubble(Characters.player, "What's behind you? Is that a ghost?!");
    public static SpeechBubble response1Branch = new SpeechBubble(Characters.witch, "Oh, you do? Well, it doesn't matter! I'm gonna kill you anyways!");
    public static SpeechBubble response2Branch = new SpeechBubble(Characters.witch, "Wow. You're lame.");
    public static SpeechBubble response3Branch = new SpeechBubble(Characters.witch, "Ah! Where?");
    public static SpeechBubble finalResponse = new SpeechBubble(Characters.witch, "Whatever. No matter what you said, it doesn't matter!");
    public static SpeechBubble anotherResponse = new SpeechBubble(Characters.player, new List<string> { "I can't believe you've done this.", "OK." });
    public static SpeechBubble lastResponse = new SpeechBubble(Characters.player, "I can't believe you've done this. That is just wrong.");
    public static SpeechBubble lastLastResponse = new SpeechBubble(Characters.player, "OK. I am seriously running out of things to say now.");
    public static SpeechBubble lastLastLastResponse = new SpeechBubble(Characters.witch, "This is annoying.");

    public static SpeechBubble memory = new SpeechBubble(Characters.player, "Huh?!");

    public static SpeechBubble flashback1a = new SpeechBubble(Characters.witch, "So if I pay you 100 gold, will you kidnap the princess for me?");
    public static SpeechBubble flashback1b = new SpeechBubble(Characters.player, "No way! My sole job is to protect the princess.");
    public static SpeechBubble flashback1c = new SpeechBubble(Characters.player, "There's no way in hell I'd kidnap her for you!");
    public static SpeechBubble flashback1d = new SpeechBubble(Characters.witch, "Then I'll have to use other methods...");
    public static SpeechBubble flashbackEnding = new SpeechBubble(Characters.player, "Wait? Kidnap the princess? She never said anything about that...");

    public static void Initialize()
    {
        firstConversation.SetLines(new List<SpeechBubble> { secondConversation });
        secondConversation.SetLines(new List<SpeechBubble> { thirdConversation });
        thirdConversation.SetLines(new List<SpeechBubble> { fourthConversation });
        fourthConversation.SetLines(new List<SpeechBubble> { responseAnswers });
        responseAnswers.SetLines(new List<SpeechBubble> { response1, response2, response3 });
        response1.SetLines(new List<SpeechBubble> { response1Branch });
        response2.SetLines(new List<SpeechBubble> { response2Branch });
        response3.SetLines(new List<SpeechBubble> { response3Branch });
        response1Branch.SetLines(new List<SpeechBubble> { finalResponse });
        response2Branch.SetLines(new List<SpeechBubble> { finalResponse });
        response3Branch.SetLines(new List<SpeechBubble> { finalResponse });
        finalResponse.SetLines(new List<SpeechBubble> { anotherResponse });
        anotherResponse.SetLines(new List<SpeechBubble> { lastResponse, lastLastResponse });
        lastResponse.SetLines(new List<SpeechBubble> { lastLastLastResponse });
        lastLastResponse.SetLines(new List<SpeechBubble> { lastLastLastResponse });
        lastLastLastResponse.SetLines(); // End of conversation.

        memory.SetLines(); // End of conversation.

        flashback1a.SetLines(new List<SpeechBubble> { flashback1b });
        flashback1b.SetLines(new List<SpeechBubble> { flashback1c });
        flashback1c.SetLines(new List<SpeechBubble> { flashback1d });
        flashback1d.SetLines(); // End of conversation.
        flashbackEnding.SetLines(); // End of conversation.
    }
}
