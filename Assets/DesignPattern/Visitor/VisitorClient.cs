using UnityEngine;
using System.Collections;

public class VisitorClient : MonoBehaviour {

	// Use this for initialization
	void Start () {
		ObjectStructure os = new ObjectStructure();

		os.Add(new ElementA());

		os.Add(new ElementB());

		Ivisitor visitorA = new VisitorA();

		os.Action(visitorA);
	}
	

}
