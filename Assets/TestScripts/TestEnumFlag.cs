using UnityEngine;
using System.Collections;
using System;
public class TestEnumFlag : MonoBehaviour {

	// Use this for initialization
	Days mD;
	void Start () {

		Days meetingDays = Days.Monday | Days.Tuesday;

		Debug.Log("11 = " + meetingDays);

		//if((meetingDays & Days.Monday) == Days.Monday)
		Debug.Log( meetingDays & Days.Monday);

		meetingDays = meetingDays ^ Days.Monday;
		Debug.Log(meetingDays);

		mD |= Days.Monday;
		Debug.Log("333 " + mD);
		mD |= Days.Tuesday;
		Debug.Log("444 " + mD);
		//mD &= Days.Monday;
		mD &= ~Days.Monday;
		Debug.Log("555 " + mD);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//每一个定义值都是一个位标志
	[Flags]
	enum Days { 
		Sunday=0x01,
		Monday=0x02,
		Tuesday=0x04,
		Wednesday=0x08,
		Thursday=0x10,
		Friday=0x20,
		Saturday=0x40
	}
}
