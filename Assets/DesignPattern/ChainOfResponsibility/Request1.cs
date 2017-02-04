using UnityEngine;
using System.Collections;

public class Request1 : Request {

	public Request1(string content):base(content){}

	public override int GetRequestLevel ()
	{
		return Levels.LEVEL1;
	}
}
