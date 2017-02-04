using UnityEngine;
using System.Collections;
//备忘录角色类，备忘录对象将发起人对象传入的状态存储起来。
public class Memento  {
	private string state;
	public Memento(string state)
	{
		this.state = state;
	}

	public string GetState()
	{
		return this.state;
	}

	public void SetState(string state)
	{
		this.state = state;
	}
}
