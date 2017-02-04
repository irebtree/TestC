using UnityEngine;
using System.Collections;

public class CustomInspector : MonoBehaviour {

	public int myInt = 0;
	public float myFloat = 0.0f;

	public bool showList = false;
	// Use this for initialization
	void Start () {
		Debug.Log("myFloat " + myFloat);
		Debug.Log("myInt " + myInt);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
