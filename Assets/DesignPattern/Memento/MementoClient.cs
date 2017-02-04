using UnityEngine;
using System.Collections;
//备忘录模式: 在不破坏封装性的前提下，捕获一个对象的内部状态，并在该对象之外保存这个状态。这样就可以将该对象恢复到原先保存的状态
public class MementoClient : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Originator o = new Originator();
		Caretaker c = new Caretaker();

		o.SetState("on");

		c.SaveMemento(o.CreatMemento());

		o.SetState("off");

		o.RestoreMemento(c.RetrieveMemento());

		Debug.Log(o.GetState());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
