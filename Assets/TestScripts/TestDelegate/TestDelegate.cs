using UnityEngine;
using System.Collections;

public class TestDelegate : MonoBehaviour {
	public delegate void MyDelegate(GameObject v);
	public event MyDelegate myDelegate;
	// Use this for initialization
	void Start () {

		if(myDelegate != null)
		{
			myDelegate(this.gameObject);
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}



	public void Test(MyDelegate my)
	{
		myDelegate += new MyDelegate (my);
	}
	
}


