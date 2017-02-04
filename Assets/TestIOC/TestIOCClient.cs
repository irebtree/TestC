using UnityEngine;
using System.Collections;

public class TestIOCClient : MonoBehaviour {

	// Use this for initialization
	void Start () {
		IOCClient client = new IOCClient();
		int year =client.GetYear();
		Debug.Log(year);
	}
	

}
