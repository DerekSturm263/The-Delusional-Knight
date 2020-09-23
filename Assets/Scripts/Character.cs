using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character
{
	public string Name;
	public Image Head;

	public Character(string name, Image head)
	{
		Name = name;
		Head = head;
		Characters.allCharacters.Add(Name, this);
	}
}
