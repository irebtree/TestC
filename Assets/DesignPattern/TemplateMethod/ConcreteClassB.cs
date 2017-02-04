using UnityEngine;
using System.Collections;

public class ConcreteClassB : AbstractClass {

	public override void PrimitiveOperation1 ()
	{
		Debug.Log("Implement operation 1 in Concreate class B.");
	}

	public override void PrimitiveOperation2 ()
	{
		Debug.Log("Implement operation 2 in Concreate class B.");
	}
}
