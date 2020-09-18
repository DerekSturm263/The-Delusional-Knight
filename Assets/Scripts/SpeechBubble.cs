using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeechBubble
{
	public Character Speaker;
	public string Dialogue;
	public List<SpeechBubble> NextLines = new List<SpeechBubble>();
	public List<string> Responses = new List<string>();

	public SpeechBubble(Character speaker, string dialogue)
	{
		Speaker = speaker;
		Dialogue = dialogue;
	}

	public SpeechBubble(Character speaker, List<string> responses)
    {
		Speaker = speaker;
		Responses = responses;
    }

	public void SetLines(List<SpeechBubble> nextLines = null)
    {
		NextLines = nextLines;
    }
}
