using UnityEngine;
using System.Collections;
using System.Threading;
using System;
public class TestEventWaitHandle : MonoBehaviour {
	private static EventWaitHandle ewh;
	private static long threadCount;
	private static EventWaitHandle clearCount = new EventWaitHandle(false ,EventResetMode.AutoReset);
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void AutoResetDemo()
	{
		ewh = new EventWaitHandle(false,EventResetMode.AutoReset);
		for(int i = 0;i <= 4; i++)
		{
			Thread t = new Thread(new ParameterizedThreadStart(ThreadProc));
			t.Start(i);
		}

		while(Interlocked.Read(ref threadCount) < 5)
		{
			Thread.Sleep(500);
		}

		while(Interlocked.Read(ref threadCount ) > 0)
		{
			Debug.Log("waiting thread ");
			WaitHandle.SignalAndWait(ewh,clearCount);
		}
	}

	public static void ThreadProc(object data)
	{
		int i = (int)data;
		Debug.Log("thread " + i + " block");
		Interlocked.Increment(ref threadCount);
		ewh.WaitOne();
		Debug.Log("Thread " + i + "exit ");
		Interlocked.Decrement(ref threadCount);
		clearCount.Set();
	}
}
