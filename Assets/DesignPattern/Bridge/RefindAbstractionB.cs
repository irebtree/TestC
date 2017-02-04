using UnityEngine;
using System.Collections;
/// <summary>
/// street road
/// </summary>
public class RefindAbstractionB : Abstraction {

	public override void Operation ()
	{
		implementor.Operation();
	}
}
