using UnityEngine;
using System.Collections;

public class TestLambda : MonoBehaviour {
	public delegate int Test(int v);
	Test t = v => v + 1;

	public delegate bool InRange(int low,int high,int val);
	InRange rangeOK = (low,high,val) => val >=low && val <= high;
	// Use this for initialization
	void Start () {
		int result = t(1);
		Debug.Log(result);

		if(rangeOK(0,5,2))
		{
			Debug.Log("yes!");
		}

		int r = 1;
		SystemActionTest(val => r = val);
		Debug.Log("r = " + r);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void SystemActionTest(System.Action<int> actionDelegate)
	{
		actionDelegate(10);
	}
}
