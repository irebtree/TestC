using UnityEngine;
using System.Collections;
/// <summary>
/// bus
/// </summary>
public class ConcreteImplementB : Implementor {

	public override void Operation ()
	{
		Debug.Log("operation B");
	}
}
