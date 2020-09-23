using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeechBubble
{
	public int ID;
	public Character Speaker;
	public string Dialogue;
	public List<SpeechBubble> NextLines = new List<SpeechBubble>();
	public List<string> Responses = new List<string>();

	public SpeechBubble(int id, Character speaker, string dialogue)
	{
		ID = id;
		Speaker = speaker;
		Dialogue = dialogue;

		AllDialogue.allDialogue.Add(ID, this);
	}

	public SpeechBubble(int id, Character speaker, List<string> responses)
    {
		ID = id;
		Speaker = speaker;
		Responses = responses;
    }

	public void SetLines(List<SpeechBubble> nextLines = null)
    {
		NextLines = nextLines;
    }
}
