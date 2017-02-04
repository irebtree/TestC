using UnityEngine;
using System.Collections;
//发起人角色类，发起人角色利用一个新创建的备忘录对象将自己的内部状态存储起来。caretaker将memento对象存到自己上面
public class Originator {

	public string state;

	public Memento CreatMemento()
	{
		return new Memento (state);
	}

	public void RestoreMemento(Memento memento)
	{
		this.state = memento.GetState();
	}

	public void SetState(string state)
	{
		this.state = state;
		Debug.Log("current state is " + state );
	}

	public string GetState()
	{
		return this.state;
	}

}
