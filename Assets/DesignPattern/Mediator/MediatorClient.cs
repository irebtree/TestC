using UnityEngine;
using System.Collections;

public class MediatorClient : MonoBehaviour {

	// Use this for initialization
	void Start () {
		ConcreteMediator m = new ConcreteMediator();
		ConcreteColleagueA a = new ConcreteColleagueA(m);
		ConcreteColleagueB b = new ConcreteColleagueB(m);

		m.SetConcreteColleagueA(a);
		m.SetConcteteColleagueB(b);

		a.Send();
		b.Send();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
