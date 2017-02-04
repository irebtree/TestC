using UnityEngine;
using System.Collections;

public class DecoratorClient : MonoBehaviour {

	// Use this for initialization
	void Start () {
		ThirdParty thirdparty = new ThirdParty();
		Debug.Log("thirdparty " + thirdparty.SayMsg());

		IThirdParty d1= new Decorator1(thirdparty);
		Debug.Log("d1 " + d1.SayMsg());

		IThirdParty d2 = new Decorator2(d1);
		Debug.Log("d2 " + d2.SayMsg());
	}
	

}
