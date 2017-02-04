using UnityEngine;
using System.Collections;

public class DLeaf : DComponent {

	public DLeaf(string name):base(name)
	{}

	public override void Add (DComponent component)
	{
		Debug.Log("Can not add a component to a leaf.");
	}

	public override void Remove (DComponent component)
	{
		Debug.Log("Can not remove a component to a leaf.");
	}

	public override void Display (int level)
	{
		Debug.Log(new string('-',level) + name);
	}
}
