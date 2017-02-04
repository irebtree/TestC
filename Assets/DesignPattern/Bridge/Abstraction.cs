using UnityEngine;
using System.Collections;

/// <summary>
/// road
/// </summary>
public abstract class Abstraction  {
	protected Implementor implementor;
	public void SetImplementor(Implementor implementor)
	{
		this.implementor = implementor;
	}
	public abstract void Operation();
}
