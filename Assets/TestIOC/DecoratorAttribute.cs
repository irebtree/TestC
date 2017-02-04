using UnityEngine;
using System.Collections;
using System;
[AttributeUsage(AttributeTargets.Class, AllowMultiple=true)]
sealed class DecoratorAttribute : Attribute {

	public readonly object Injector;
	private Type type;

	public DecoratorAttribute(Type type)
	{
		if(type == null)
			return;
		this.type = type;
		Injector = new IOCAssembler().Create(this.type);


	}

	public Type Type{get{return this.type;}}
}
