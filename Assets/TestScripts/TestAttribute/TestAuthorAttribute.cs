using UnityEngine;
using System.Collections;

public class TestAuthorAttribute : MonoBehaviour {

	// Use this for initialization
	void Start () {
		PrintAuthorInfo(typeof (AttributeClass1));
		PrintAuthorInfo (typeof(AttributeClass2));
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	static void PrintAuthorInfo(System.Type t)
	{
		Debug.Log ( t);
		System.Attribute[] attrs = System.Attribute.GetCustomAttributes (t);
		foreach (System.Attribute attr in attrs)
		{
			Author a = (Author)attr;
			Debug.Log(a.Name);
			Debug.Log(a.virsion);
		}
	}
}
