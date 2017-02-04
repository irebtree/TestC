using UnityEngine;
using System.Collections;
using System;
public class TestIDisposable : MonoBehaviour,IDisposable {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Dispose()
	{ 
		//GC.SuppressFinalize(this);   
		Debug.Log("dispose ");
	}
}
