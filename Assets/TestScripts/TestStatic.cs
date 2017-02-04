using UnityEngine;
using System.Collections;
public class MyClass{
	public string my = "PP";
}
public class TestStatic : MonoBehaviour {
	public static string t1;
	public  MyClass mc = new MyClass();
	// Use this for initialization
	void Start () {
		Test();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public static void Test()
	{
		t1 = "t1";

		MyClass m =new MyClass();
		Debug.Log(m.my);

		//mc.my = "";
		//NoStatic();

		Static();
		
	}

	public void NoStatic()
	{

	}

	public static void Static()
	{}
}
