using UnityEngine;
using System.Collections;
using System.Threading;
public class TestInterLocked : MonoBehaviour {
	[HideInInspector]
	public static int count = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	class IncThread
	{
		public Thread Thre;
		public IncThread(string name)
		{
			Thre = new Thread(this.Run);
			Thre.Name = name;
			Thre.Start();
		}
		void Run()
		{
			for(int i=0;i<5;i++)
			{
				Interlocked.Increment(ref count);
				Debug.Log(Thre.Name + "count is "+ count);
			}
		}
	}

	class DecThread
	{
		public Thread Thre;
		public DecThread(string name)
		{
			Thre = new Thread(this.Run);
			Thre.Name = name;
			Thre.Start();
		}
		void Run()
		{
			for(int i=0;i<5;i++)
			{
				Interlocked.Decrement(ref count);
				Debug.Log(Thre.Name + "count is "+ count);
			}
		}
	}

	public void excute()
	{
		IncThread t1 = new IncThread("IncThread ");
		DecThread t2 = new DecThread("DecThread ");
		t1.Thre.Join();
		t2.Thre.Join();
	}
}
