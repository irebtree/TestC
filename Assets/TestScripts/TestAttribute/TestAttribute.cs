using UnityEngine;
using System.Collections;

public class TestAttribute : MonoBehaviour {
	private int val = 10;

	public int MyAttribute
	{
		get{return val;}
		set{val = 100;}
	}
	// Use this for initialization
	void Start () {
		//MyAttribute = -10;
		//Debug.Log (MyAttribute);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
