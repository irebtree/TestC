using UnityEngine;
using System.Collections;

public class COResponsibilityClient : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		Handler handler1 =new Handler1();
		Handler handler2 = new Handler2();

		handler1.SetNextHandler(handler2);

		Request request1 = new Request1("requset1 ");
		Request request2 = new Request2("requset2 ");

		handler1.HandleRequest(request1);
		handler1.HandleRequest(request2);

	}
	

}
