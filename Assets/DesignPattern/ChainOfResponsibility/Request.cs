using UnityEngine;
using System.Collections;

public abstract class Request {
	private string content = null;
	public Request(string content)
	{
		this.content = content;
	}

	public string Content()
	{
		return content;
	}

	public abstract int GetRequestLevel();
}
