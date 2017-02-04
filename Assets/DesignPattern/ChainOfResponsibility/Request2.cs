using UnityEngine;
using System.Collections;

public class Request2 : Request {
	public Request2(string content):base(content){}

	public override int GetRequestLevel ()
	{
		return Levels.LEVEL2;
	}
}
