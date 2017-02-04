using UnityEngine;
using System.Collections;

public class TestMonoBehaviourHelper : MonoBehaviour {

	// Use this for initialization
	void Start () {
		MonoBehaviourHelper.StartCoroutine(T ());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator T()
	{
		Debug.Log(">>>");
		yield break;
	}
}
