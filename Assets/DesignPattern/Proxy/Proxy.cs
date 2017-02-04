using UnityEngine;
using System.Collections;

public class Proxy : ISubject {

	private RealSubject realSubject;

	public Proxy()
	{
		realSubject = new RealSubject();
	}

	public void Function1()
	{
		realSubject.Function1();
	}

	public void Function2()
	{
		realSubject.Function2();
	}
}
