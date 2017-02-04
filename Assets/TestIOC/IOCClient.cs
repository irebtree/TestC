using UnityEngine;
using System.Collections;
[DecoratorAttribute(typeof(ITimeProvider))] //  基于Attribute实现注入
public class IOCClient  {
	private ITimeProvider timeProvider;

//	public ITimeProvider TimeProvider
//	{
//		get{return this.timeProvider;}
//		set{this.timeProvider = value;}
//	}

	public int GetYear()
	{
		timeProvider = DecoratorAttributeHelper.Injector<ITimeProvider>(this);
		return timeProvider.CurrentDate.Year;
	}
}
