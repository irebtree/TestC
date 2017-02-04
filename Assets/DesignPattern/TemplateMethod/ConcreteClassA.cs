using UnityEngine;
using System.Collections;

public class ConcreteClassA : AbstractClass {

	public override void PrimitiveOperation1 ()
	{
		Debug.Log("Implement operation 1 in Concreate class A.");
	}

	public override void PrimitiveOperation2 ()
	{
		Debug.Log( "Implement operation 2 in Concreate class A.");
	}

}
