using UnityEngine;
using System.Collections;

public class ConcreteStateA : State {

	public void Handle(string sampleParameter)
	{
		Debug.Log("stateA handle " + sampleParameter);
	}
}
