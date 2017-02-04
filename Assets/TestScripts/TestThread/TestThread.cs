using UnityEngine;
using System.Collections;
using System.Threading;

class MyThread{
	public int count;
	public Thread thrd;

	public MyThread(string name ,int num)
	{
		count = 0;
		thrd = new Thread (this.Run);
		thrd.Name = name;
		thrd.Start (num);

	}

	void Run(object num)
	{
		Debug.Log (thrd.Name + " starting.");
		do {
						Thread.Sleep (500);
						Debug.Log ("In " + thrd.Name + ",count is " + count);
						count++;
		} while(count < (int)num);

		Debug.Log (thrd.Name + "termineiting.");
	}
}

public class TestThread : MonoBehaviour {

	// Use this for initialization
	void Start () {

		Debug.Log ("main thread starting!");
		MyThread myThtread1 = new MyThread ("child #1",10);
		MyThread myThtread2 = new MyThread ("child #2",10);
		MyThread myThtread3 = new MyThread ("child #3",10);

//		do {
//						Debug.Log (".");
//						Thread.Sleep (100);
//		} while(myThtread1.count < 10 || myThtread2.count < 10 || myThtread3.count < 10);
//		Debug.Log ("main thread ending!");
		myThtread1.thrd.Join ();//jian cha ci xian cheng shi fou yi zhong jie
		myThtread2.thrd.Join ();
		myThtread3.thrd.Join ();
		Debug.Log ("main thread ending!");

	}
	
	// Update is called once per frame
	void Update () {
	
	}


}
