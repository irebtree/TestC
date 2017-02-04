using UnityEngine;
using System.Collections;

public class BridgeClient : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Abstraction refinfAbstractionA = new RefindAbstractionA();
		refinfAbstractionA.SetImplementor(new ConcreteImplementA());
		refinfAbstractionA.Operation();
		refinfAbstractionA.SetImplementor(new ConcreteImplementB());
		refinfAbstractionA.Operation();

		Abstraction refindAbstractionB = new RefindAbstractionB();
		refindAbstractionB.SetImplementor(new ConcreteImplementA());
		refindAbstractionB.Operation();
	}
	

}
