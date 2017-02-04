using UnityEngine;
using System.Collections;

public class ElementA : Element {

	public override void Accept (Ivisitor visitor)
	{
		visitor.Visit(this);
	}

	public void OperationA()
	{
		Debug.Log("operation A");
	}
}
