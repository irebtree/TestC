using UnityEngine;
using System.Collections;
//Context类，维护一个ConcreteState子类的实例，这个实例定义当前的状态。
public class Context  {

	private State state;


	public State State{get{return state;}set{state = value;}}

	public void Request(string sampleParameter)
	{
		this.state.Handle(sampleParameter);
	}
}
