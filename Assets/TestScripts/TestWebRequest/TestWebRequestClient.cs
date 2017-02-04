using UnityEngine;
using System.Collections;

public class TestWebRequestClient : MonoBehaviour {
	public string url;
	// Use this for initialization
	void Start () {
		int r=0;
		JustForTest(val=> r =val);
		Debug.Log("r = " + r);

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Test()
	{
		StartCoroutine(CheckForMissingURl());
		//TestWebRequest server = new TestWebRequest();
		//StartCoroutine(server.BeginSendAndReceive(url));
	}

	public IEnumerator CheckForMissingURl()
	{
		bool foundURL = false;
		TestWebRequest server = new TestWebRequest();
		yield return StartCoroutine(server.BeginSendAndReceive(url,val => foundURL = !val));
		Debug.Log("Does "+ url +" exist? "+ foundURL);
	}

	void JustForTest(System.Action<int> result)
	{
		result (10);
	}
}
