using UnityEngine;
using System.Collections;

public class WebSiteUser  {

	private string name;
	public WebSiteUser(string name)
	{
		this.name = name;
	}
	public string Name{get{return name;}private set{name = value;}}
}
