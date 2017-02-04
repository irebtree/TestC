using UnityEngine;
using System.Collections;
using System;
public static class DecoratorAttributeHelper  {

	public static T Injector<T>(object target) where T : class
	{
		if(target == null)
		{
			throw new ArgumentNullException("tartet");
		}

		Type targetType = target.GetType();

		//方法1
		//object[] attributes = targetType.GetCustomAttributes(typeof(DecoratorAttribute), false);
	//	if ((attributes == null) || (attributes.Length <= 0)) return null ;


//		foreach (DecoratorAttribute attribute in 
//		         (DecoratorAttribute[])attributes)
//			
//			if (attribute.Type == typeof(T))
//				
//				return (T)attribute.Injector;
//
		//方法2
		DecoratorAttribute da =(DecoratorAttribute) Attribute.GetCustomAttribute(targetType, typeof(DecoratorAttribute));
		return (T)da.Injector;

		return null;
	}
}
