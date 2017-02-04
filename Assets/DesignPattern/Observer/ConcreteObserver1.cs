using UnityEngine;
using System.Collections;

public class ConcreteObserver1 : Observer {

	private string observerState;
	private ConcreteSubject subject;
	
	public ConcreteObserver1(ConcreteSubject subject)
	{
		this.subject = subject;
	}
	public void Update()
	{
		observerState = subject.subjectState;
		Debug.Log("obs1 state is>>> " + observerState);
	}
}
