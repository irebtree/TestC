using UnityEngine;
using System.Collections;

public class Adapter : Tartget {
	private Adaptee adaptee = new Adaptee();
	public override void Request ()
	{
		adaptee.MyRequest();
	}
}
