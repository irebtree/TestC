using UnityEngine;
using System.Collections;

public class TestContextMenu : MonoBehaviour {
	[ContextMenuItem("Reset My int", "ResetMyInt")]
	public int myInt = 0;
	[ContextMenu("set int")]
	protected void SetInt()
	{
		myInt = 10;
	}

	protected void ResetMyInt()
	{
		myInt = 0;
	}
}
