using UnityEngine;
using System.Collections;

public class PersonContext  {
	private IStrategy strategy;
	public PersonContext(IStrategy strategy)
	{
		this.strategy = strategy;
	}

	public void Execute()
	{
		strategy.Algorithm();
	}
}
