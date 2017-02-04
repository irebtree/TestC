using UnityEngine;
using System.Collections;
using System;
public class Prototype : ICloneable {

	public object Clone()
	{
		Prototype prototype = new Prototype();


		return prototype;
	}

	public void Show()
	{
		Debug.Log( "原型模式实现类"); 
	}
}
