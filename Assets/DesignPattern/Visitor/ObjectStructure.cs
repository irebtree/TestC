using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class ObjectStructure  {
	private List<Element> elements = new List<Element>();
	public void Action (Ivisitor visitor)
	{
		foreach(var element in elements)
		{
			element.Accept(visitor);
		}
	}

	public void Add(Element element)
	{
		elements.Add(element);
	}

}
