using UnityEngine;
using System.Collections;
/// <summary>
/// speed road
/// </summary>
public class RefindAbstractionA : Abstraction {
public override void Operation ()
	{
		implementor.Operation();
	}
}
