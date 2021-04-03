using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInteraction : Interactable
{
	protected override void Interact()
	{
		base.Interact();
		Debug.Log("You meet GOLEM!!!");
	}
}
