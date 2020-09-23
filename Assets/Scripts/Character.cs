using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character
{
	public string Name;
	public Sprite Head;

	public Character(string name)
	{
		Name = name;
		Characters.allCharacters.Add(Name, this);
	}

	public void SetIcon(Sprite s)
	{
		Head = s;
	}
}
