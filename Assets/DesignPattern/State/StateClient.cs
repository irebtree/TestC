using UnityEngine;
using System.Collections;
//状态模式允许一个对象在其内部状态改变的时候改变其行为。这个对象看上去就像是改变了它的类一样。
public class StateClient : MonoBehaviour {
	public bool test;
	
	Context co;
	State a;
	State b;

	void Start () {
		 co = new Context();
		 a =  new ConcreteStateA();
		 b = new ConcreteStateB();


	}
	
	// Update is called once per frame
	void Update () {
		if(test)
			co.State = a;
		else
			co.State = b;
		
		co.Request("test ");
	}
}
