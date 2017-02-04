using UnityEngine;
using System.Collections;
using System.Threading;
public class TestThreadLock : MonoBehaviour {

	void Start () {
		int [] a = {1,2,3,4,5};
		MyThread2 mt1 = new MyThread2 ("Child #1 ", a);
		MyThread2 mt2 = new MyThread2 ("Child #2 ", a);
		mt1.thrd.Join ();
		mt2.thrd.Join ();
	
	}
	

}

class SumArray{
	int sum;

	object ojLock = new object ();
	public int SumIt(int[] nums)
	{
		//lock(ojLock)
		//{
			sum = 0;
			for (int i=0; i<nums.Length; i++)
			{
				sum += nums[i];
				Debug.Log("running total for " + Thread.CurrentThread.Name + "is " + sum);
				Thread.Sleep(10);
			}

			return sum;
		//}
	}
}

class MyThread2{

	public Thread thrd;
	int [] a;
	int answer;

	static SumArray sa = new SumArray ();

	public MyThread2(string name, int[] nums)
	{
		a = nums;
		thrd = new Thread (this.Run);
		thrd.Name = name;
		thrd.Start ();
	}

	void Run()
	{
		Debug.Log (thrd.Name + "starting");
		//answer = sa.SumIt (a);
		lock (sa) answer = sa.SumIt (a);
		Debug.Log ("sum for " + thrd.Name + " is " + answer);
		Debug.Log (thrd.Name + " terminating");
	}
}
