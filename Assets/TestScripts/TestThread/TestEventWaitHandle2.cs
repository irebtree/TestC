using UnityEngine;
using System.Collections;
using System.Threading;
public class TestEventWaitHandle2 : MonoBehaviour {


	class MyThread
	{
		public Thread thre;
		ManualResetEvent mre;
		public MyThread(string name,ManualResetEvent evt)
		{
			thre = new Thread(this.Run);
			thre.Name = name;
			mre = evt;
			thre.Start();
		}
		void Run()
		{
			Debug.Log("Inside thread " + thre.Name);
			for(int i=0;i<5;i++)
			{
				Debug.Log(thre.Name);
				Thread.Sleep(500);
			}
			Debug.Log(thre.Name + " done");
			mre.Set();//置为发出信号状态
		}
	}

	public void ManualResetDemo()
	{
		ManualResetEvent evtObj = new ManualResetEvent(false);//false 表示将对象置于未发出信号状态
		MyThread t1 = new MyThread("Event Thread 1",evtObj);//开辟一个线程
		Debug.Log("main thread waiting for event ");
		evtObj.WaitOne();//直到t1发出信号才执行下面语句,通过.set()方法,
		Debug.Log("main thread recieved first event ");

		// reset the event 
		evtObj.Reset();//重置为未发出信号状态

		t1 = new MyThread("Event Thread 2",evtObj);
		evtObj.WaitOne();
		Debug.Log("main thread recieved second event ");
	}
}
