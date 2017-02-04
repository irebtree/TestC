using UnityEngine;
using System.Collections;
//观察者模式:定义对象间一种一对多的依赖关系，使得当每一个对象改变状态，则所有依赖于它的对象都会得到通知并自动更新。
public class ObserverClient : MonoBehaviour {

	void Start()
	{
		ConcreteSubject sub = new ConcreteSubject();


		sub.AddObserver(new ConcreteObserver1(sub));
		sub.AddObserver(new ConcreteObserver2(sub));

		sub.subjectState = "ready";
		sub.NotifiObservers();

		sub.subjectState = "go";
		sub.NotifiObservers();
	}
}
