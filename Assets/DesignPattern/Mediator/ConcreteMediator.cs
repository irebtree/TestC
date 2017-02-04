using UnityEngine;
using System.Collections;

public class ConcreteMediator : Mediator {

	private ConcreteColleagueA colleagueA;
	private ConcreteColleagueB colleagueB;

	public void SetConcreteColleagueA(ConcreteColleagueA colleague)
	{
		colleagueA = colleague;
	}

	public void SetConcteteColleagueB(ConcreteColleagueB colleague)
	{
		colleagueB = colleague;
	}


	public override void Change (Colleague colleague)
	
	{
		if(colleagueA == colleague)
		{
			colleagueB.SomeOperation();
		}
		else
		{
			colleagueA.SomeOperation();
		}
	}
}
