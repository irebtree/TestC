using UnityEngine;
using System.Collections;

public class ConcreteStateB : State {

	public void Handle(string sampleParameter)
	{
		Debug.Log("stateB handle " + sampleParameter);
	}
}
