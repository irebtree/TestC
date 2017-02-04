using UnityEngine;
using System.Collections;

public class Decorator2 : IThirdParty {

	private IThirdParty d1;
	public Decorator2(IThirdParty d1)
	{
		this.d1 = d1;
	}
	public string SayMsg()
	{
		return d1.SayMsg() + "Decorator2";
	}
}
