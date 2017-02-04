using UnityEngine;
using System.Collections;

public class EventBehaior : MonoBehaviour {
	public TestDelegate testDelegate;
	// Use this for initialization
	void Start () {

		testDelegate = GetComponent<TestDelegate>();
		testDelegate.myDelegate += myDelegate;

		testDelegate.Test(myDelegate1);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void myDelegate(GameObject go)
	{
		Debug.Log("yes! ");
	}

	void myDelegate1(GameObject go)
	{
		Debug.Log("yes1111! ");
	}
}


