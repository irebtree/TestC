using UnityEngine;
using System.Collections;

public class CustomData : MonoBehaviour {
	public IntVector2 a;
	public IntVector2 b;
	public IntVector2 c;
	// Use this for initialization
	void Start () {
		c = b - a;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

}
