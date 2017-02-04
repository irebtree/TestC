using UnityEngine;
using System.Collections;

public class TestCoroutine : MonoBehaviour {
	public bool boolVal;

	// Use this for initialization
	void Start () {
		//StartCoroutine(CountDown());
		//Debug.Log("01 " + System.DateTime.Now);
		//StartCoroutine(SaySomeThings());
	//yield return StartCoroutine(SaySomeThings());

		//StartCoroutine(T ());

		//F1();

		//Test();
		//Test1();
		StartCoroutine(Test1());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator CountDown()
	{

		for(float timer = 3;timer >=0;timer -= Time.deltaTime)
		{
			yield return 0;
		}

		Debug.Log("03 " + System.DateTime.Now);
	}

	IEnumerator SaySomeThings()
	{
		Debug.Log("The routine has started");
		yield return new WaitForSeconds(1f);
		Debug.Log("1 second has passed since the last message");
		yield return new WaitForSeconds(2.5f);
		Debug.Log("2.5 seconds have passed since the last message");
	}

	IEnumerator T()
	{
		while(boolVal)
		{
			Debug.Log("***");
			yield return 0;
		}
	}


	string F1()
	{
		//F2 ();
		Debug.Log("F1 ");
		return "my F1 ";
	}

	void F2()
	{
		Debug.Log("F 2 ");
	}


	void Test()
	{
		StartCoroutine(Do());
		print("This is printed immediately");
	}

	IEnumerator Test1()
	{
		Debug.Log("***");
		yield return StartCoroutine(Do());
		print("Also after 2 seconds"); 
		print ("This is after the Do coroutine has finished execution"); 
	}

	IEnumerator Do()
	{
		print("do now ");
		yield return new WaitForSeconds(2f);
		print("do 2 seconds later");
	}
}
