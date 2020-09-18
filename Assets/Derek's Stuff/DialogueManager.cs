using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DialogueManager : MonoBehaviour
{
	public EventSystem eventSystem;

	[HideInInspector] public Character speaker1; // Speaker on the left.
	[HideInInspector] public Character speaker2; // Speaker on the right.

	[HideInInspector] public Character currentSpeaker; // Current speaker.
	[HideInInspector] public SpeechBubble currentDialogue; // Current running line of dialogue.
	[HideInInspector] public Image currentDialogueBG; // Current background for dialogue.
	[HideInInspector] public Text currentDialogueText; // Current text for dialogue.

	public Material speechMaterial;
	public Material thinkingMaterial;

	public int responseNum = -1;

	public GameObject allDialogueGUI;
	public Text dialogueText1GUI;
	public Text dialogueText2GUI;
	public Image dialogueBG1;
	public Image dialogueBG2;
	public Image speaker1GUI;
	public Image speaker2GUI;
	public Text speaker1Name;
	public Text speaker2Name;

	public GameObject responsesLayout;
	public Button buttonTemplate;

	private bool canSkip = false;
	private float waitTime = 0.05f;

	// Start with this piece of code to set who’s talking.
	public void SetupDialogue(Character character1, Character character2)
	{
		speaker1 = character1;
		speaker2 = character2;

		speaker1GUI = speaker1.Head;
		speaker2GUI = speaker2.Head;

		speaker1Name.text = speaker1.Name;
		speaker2Name.text = speaker2.Name;
	}

	// Continue with this line of code to make one of them start talking.
	public void StartDialogue(SpeechBubble firstDialogue)
	{
		currentDialogue = firstDialogue;
		currentSpeaker = currentDialogue.Speaker;

		dialogueBG1.gameObject.SetActive(false);
		dialogueBG2.gameObject.SetActive(false);

		if (currentDialogue.Responses.Count > 0)
			StartCoroutine(WriteResponses(currentDialogue.Responses));
		else
			StartCoroutine(Write(currentDialogue.Dialogue));
	}

	// Used to advance dialogue that has no branches.
	public void AdvanceDialogue()
	{
		if (currentDialogue.NextLines != null)
		{
			currentDialogue = currentDialogue.NextLines[0];
			currentSpeaker = currentDialogue.Speaker;

			if (currentDialogue.Responses.Count > 0)
				StartCoroutine(WriteResponses(currentDialogue.Responses));
			else
				StartCoroutine(Write(currentDialogue.Dialogue));
		}
		else
		{
			StopDialogue();
		}
	}

	// Used to advance dialogue that can branch with different options.
	public void AdvanceDialogue(int responseNumber)
	{
		if (currentDialogue.NextLines != null)
		{
			currentDialogue = currentDialogue.NextLines[responseNumber];

			currentSpeaker = currentDialogue.Speaker;

			if (currentDialogue.Responses.Count > 0)
				StartCoroutine(WriteResponses(currentDialogue.Responses));
			else
				StartCoroutine(Write(currentDialogue.Dialogue));
		}
		else
		{
			StopDialogue();
		}
	}

	// Ends the conversation between characters.
	public void StopDialogue()
	{
		currentSpeaker = null;
		currentDialogue = null;

		allDialogueGUI.GetComponent<Animator>().SetBool("Exit", true);
		currentDialogueBG.GetComponent<Animator>().SetBool("Done", true);
	}

	public void SkipDialogue()
	{
		if (!canSkip)
		{
			waitTime = 0f;
			canSkip = true;
		}
		else
		{
			try
			{
				responseNum = eventSystem.currentSelectedGameObject.GetComponent<Response>().responseNum;
			}
			catch { }

			if (currentDialogueBG.material == speechMaterial) AdvanceDialogue();
			else if (responseNum != -1) AdvanceDialogue(responseNum);
		}
	}

	public void SwitchSpeaker(bool isResponding)
	{
		Image oldBG = null;
		try
		{
			oldBG = currentDialogueBG;
			currentDialogueText.gameObject.SetActive(false);

			if (responsesLayout.gameObject.activeSelf) responsesLayout.gameObject.SetActive(false);
		} catch { }

		if (currentSpeaker == speaker1)
		{
			currentDialogueText = dialogueText1GUI;
			currentDialogueBG = dialogueBG1;
		}
		else
		{
			currentDialogueText = dialogueText2GUI;
			currentDialogueBG = dialogueBG2;
		}

		if (oldBG != null && oldBG != currentDialogueBG)
			oldBG.GetComponent<Animator>().SetBool("Exit", true);

		if (!isResponding) currentDialogueText.gameObject.SetActive(true);
		else responsesLayout.gameObject.SetActive(true);

		currentDialogueBG.gameObject.SetActive(true);
		currentDialogueBG.GetComponent<Canvas>().sortingOrder = 2;
		currentDialogueBG.material = (!isResponding) ? speechMaterial : thinkingMaterial;
		currentDialogueBG.color = Color.white;
	}

	// Writes text to text box.
	private IEnumerator Write(string text)
	{
		SwitchSpeaker(false);
		Text output = currentDialogueText;

		canSkip = false;
		waitTime = 0.05f;
		output.text = "";

		for (int i = 0; i < text.Length; i++)
		{
			output.text += text[i];

			yield return new WaitForSeconds(waitTime);
		}

		canSkip = true;
	}

	private IEnumerator WriteResponses(List<string> responses)
    {
		SwitchSpeaker(true);
		responseNum = -1;

		Transform[] responseArray = responsesLayout.GetComponentsInChildren<Transform>();
		foreach (Transform response in responseArray)
        {
			if (response.gameObject != responsesLayout)
				Destroy(response.gameObject);
        }

		foreach (string response in responses)
        {
			Button newResponse = Instantiate(buttonTemplate, responsesLayout.transform);
			newResponse.GetComponentInChildren<Text>().text = response;
			newResponse.GetComponent<Response>().responseNum = responses.IndexOf(response);
        }

		yield return null;
    }

    private void Awake()
    {
		AllDialogue.Initialize();
		eventSystem = EventSystem.current;

		SetupDialogue(Characters.player, Characters.witch);
		StartDialogue(AllDialogue.firstConversation);
    }

    private void Update()
    {
		// Lets the user input "Fire1" to skip through dialogue.
		if (Input.GetButtonDown("Fire1"))
			SkipDialogue();
    }
}
