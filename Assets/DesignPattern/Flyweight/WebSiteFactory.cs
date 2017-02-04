using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class WebSiteFactory  {

	private Dictionary<string,ConcreteWebsite> flyweights = new Dictionary<string, ConcreteWebsite>();

	public WebSite GetWebSiteType(string key)
	{
		if(!flyweights.ContainsKey(key))
			flyweights.Add(key,new ConcreteWebsite(key));
		return flyweights[key] as WebSite;
	}

	public int GetWebSiteCount()
	{
		return flyweights.Count;
	}
}
