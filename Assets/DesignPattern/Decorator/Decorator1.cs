using UnityEngine;
using System.Collections;

public class Decorator1 : IThirdParty {
	private IThirdParty thirdParty;
	public Decorator1(IThirdParty thirdParty)
	{
		this.thirdParty = thirdParty;
	}
	public string SayMsg()
	{

		return thirdParty.SayMsg() + "Decorator1 ";
	}
}
