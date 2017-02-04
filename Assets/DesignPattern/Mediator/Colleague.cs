using UnityEngine;
using System.Collections;

public abstract class Colleague {
	protected Mediator mediator;
	public Colleague(Mediator mediator)
	{
		this.mediator = mediator;
	}


}
