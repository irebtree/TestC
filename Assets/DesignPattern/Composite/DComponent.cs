using UnityEngine;
using System.Collections;

public abstract class DComponent {
	protected string name;
	public DComponent(string name)
	{
		this.name = name;
	}

	public abstract void Add(DComponent component);

	public abstract void Remove(DComponent component);

	public abstract void Display(int level);
}
