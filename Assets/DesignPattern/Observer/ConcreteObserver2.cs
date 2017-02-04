using UnityEngine;
using System.Collections;

public class ConcreteObserver2 : Observer {
	private string observerState;
	private ConcreteSubject subject;

	public ConcreteObserver2(ConcreteSubject subject)
	{
		this.subject = subject;
	}
	public void Update()
	{
		observerState = subject.subjectState;
		Debug.Log("obs2 state is>>> " + observerState);
	}
}
