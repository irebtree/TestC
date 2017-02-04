using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class DComposite : DComponent {
	public DComposite(string name):base(name)
	{}

	private List<DComponent> children = new List<DComponent>();

	public override void Add (DComponent component)
	{
		children.Add(component);
	}

	public override void Remove (DComponent component)
	{
		children.Remove(component);
	}

	public override void Display (int level)
	{
		Debug.Log(new string('-',level) + name);
		foreach (DComponent component in children)
		{
			component.Display(level+2);
		}
	}
}
