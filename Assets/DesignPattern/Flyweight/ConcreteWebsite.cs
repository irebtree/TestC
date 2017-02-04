using UnityEngine;
using System.Collections;

public class ConcreteWebsite : WebSite {

	private string name;

	public ConcreteWebsite(string name)
	{
		this.name = name;
	}

	public override void Use (WebSiteUser user)
	{
		Debug.Log("webType " + name + "user " + user.Name);
	}
}
