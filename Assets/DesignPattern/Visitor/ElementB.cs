using UnityEngine;
using System.Collections;

public class ElementB : Element {

	public override void Accept (Ivisitor visitor)
	{
		visitor.Visit(this);
	}

	public void OperationB()
	{
		Debug.Log("operation b ");
	}
}
