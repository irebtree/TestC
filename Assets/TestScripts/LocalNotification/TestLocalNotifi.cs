using UnityEngine;
using System.Collections;

public class TestLocalNotifi : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	#if UNITY_IPHONE
	public void StartNotifiCation()
	{

		LocalNotificationHelper.ScheduleLocalNotification(3f,"Test",1,false);
	}
	public void ClearNotification()
	{
		LocalNotificationHelper.ClearNotification();
	}
#endif
}
