using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
public class IOCAssembler  {
	private Dictionary<Type, Type> dic = new Dictionary<Type, Type>();
	public IOCAssembler()
	{
		dic.Add(typeof(ITimeProvider), typeof(SytemTimeProvider));
	}

	public T Create<T>()
	{
		return (T) Create(typeof(T));
	}

	public object Create(Type type)
	{
		Type targetType = dic[type];
		return Activator.CreateInstance(targetType);
	}
}
