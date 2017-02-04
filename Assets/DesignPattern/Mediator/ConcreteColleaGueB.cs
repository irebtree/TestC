using UnityEngine;
using System.Collections;

public class ConcreteColleagueB : Colleague {
	public ConcreteColleagueB(Mediator mediator):base(mediator){}

	public void SomeOperation()
	{
		Debug.Log(" B operation ");

	}
	public void Send()
	{
		mediator.Change(this);
	}
}
