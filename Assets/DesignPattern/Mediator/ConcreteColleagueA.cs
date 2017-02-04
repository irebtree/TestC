using UnityEngine;
using System.Collections;

public class ConcreteColleagueA : Colleague {

	public ConcreteColleagueA(Mediator mediator):base(mediator){}
	public void SomeOperation()
	{
		Debug.Log(" A operation ");

	}

	public void Send()
	{
		mediator.Change(this);
	}
}
