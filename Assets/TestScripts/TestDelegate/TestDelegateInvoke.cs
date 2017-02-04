using UnityEngine;
using System.Collections;
using System;

public class TestDelegateInvoke : MonoBehaviour {
	public delegate void MyHandle(int a, int b);
	public event MyHandle myEvent;
	// Use this for initialization
	void Start () {
		MyHandle handle  = new MyHandle(InvokeMethod);
		MyHandle handle2 = new MyHandle(InvokeMethod2);
		myEvent += InvokeMethodE;

		handle.Invoke(1,3);//委托的Invoke方法用来进行同步调用。同步调用也可以叫阻塞调用，它将阻塞当前线程，然后执行调用，调用完毕后再继续向下进行。
		IAsyncResult result = handle2.BeginInvoke(1,3,new AsyncCallback(CallBaclMeth),null);
		handle2.EndInvoke(result);


		myEvent(1,3);

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void InvokeMethod(int a,int b)
	{
		int c = a+b;
		Debug.Log("c= " + c);
	}

	public void InvokeMethod2(int a,int b)
	{
		int c = a+b;
		Debug.Log("c2= " + c);
	}

	public void InvokeMethodE(int a,int b)
	{
		int c = a+b;
		Debug.Log("cE = " + c);
	}

	public void CallBaclMeth(IAsyncResult r)
	{
		Debug.Log("call back ");
		//GetComponent<Transform>();
	}
}
