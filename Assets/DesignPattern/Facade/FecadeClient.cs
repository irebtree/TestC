using UnityEngine;
using System.Collections;

public class FecadeClient : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Facade facade = new Facade();
		facade.MethodA();

		facade.MethodB();
	}
	

}
