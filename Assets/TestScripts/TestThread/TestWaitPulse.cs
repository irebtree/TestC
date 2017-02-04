using UnityEngine;
using System.Collections;
using System.Threading;
using System.Net;
public class TestWaitPulse : MonoBehaviour {

	void Start () {
	
		TickTock tt = new TickTock ();
		MyThread3 mt1 = new MyThread3 ("Tick",tt);
		MyThread3 mt2 = new MyThread3 ("Tock", tt);


	}

}

class TickTock{
	object lockon = new object ();
	public void Tick(bool running)
	{
		lock(lockon)
		{
			if(!running)
			{
				Monitor.Pulse(lockon);
					return;
			}
			Debug.Log("Tick ");
			Monitor.Pulse(lockon);
			Monitor.Wait(lockon);
		}
		
	}

	public void Tock(bool running)
	{
		lock(lockon)
		{
			if(!running)
			{
				Monitor.Pulse(lockon);
				return;
			}
			Debug.Log("Tock ");
			Monitor.Pulse(lockon);
			Monitor.Wait(lockon);
		}
	}
}


class MyThread3{
	public Thread thrd;
	public TickTock ttob;

	public MyThread3(string name,TickTock tt)
	{
		thrd = new Thread (this.Run);
		ttob = tt;
		thrd.Name = name;
		thrd.Start ();
	}

	void Run()
	{
		if (thrd.Name == "Tick")
		{
			for(int i = 0; i<5;i++) ttob.Tick(true);
			ttob.Tick(false);

		}
		else
		{
			for(int i=0;i<5;i++) ttob.Tock(true);
			ttob.Tock(false);
		}
	}
}
