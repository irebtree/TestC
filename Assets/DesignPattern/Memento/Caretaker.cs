using UnityEngine;
using System.Collections;
//负责人角色类，负责人角色负责保存备忘录对象，但是从不修改（甚至不查看）备忘录对象的内容
public class Caretaker  {

	private Memento memento;
	//备忘录的取值方法
	public Memento RetrieveMemento()
	{
		return this.memento;
	}

	public void SaveMemento(Memento memento)
	{
		this.memento = memento;
	}
}
