using System;
#if UNITY_IPHONE
using LocalNotification = UnityEngine.iOS.LocalNotification;
using NotificationServices = UnityEngine.iOS.NotificationServices;

public static class LocalNotificationHelper  {


	public static void ScheduleLocalNotification(float time,string message,int badges,bool isRepeatDay)
	{
		LocalNotification localNotify = new LocalNotification();

		localNotify.fireDate = DateTime.Now.AddSeconds(time);
		localNotify.alertBody = message;
		localNotify.applicationIconBadgeNumber = badges;
		localNotify.hasAction = true;
		if(isRepeatDay)
		{
			localNotify.repeatCalendar = UnityEngine.iOS.CalendarIdentifier.GregorianCalendar;
			localNotify.repeatInterval = UnityEngine.iOS.CalendarUnit.Day;
		}
		localNotify.soundName = LocalNotification.defaultSoundName;
		//UnityEngine.iOS.NotificationServices.RegisterForLocalNotificationTypes(LocalNotificationType.Alert | LocalNotificationType.Badge | LocalNotificationType.Sound);
		NotificationServices.ScheduleLocalNotification(localNotify);
		//Debug.Log("send :");
	}

	public static void ClearNotification()
	{
		LocalNotification temp = new LocalNotification (); 
		temp.applicationIconBadgeNumber = -1000; 
		NotificationServices.PresentLocalNotificationNow (temp); 
		NotificationServices.CancelAllLocalNotifications (); 
		NotificationServices.ClearLocalNotifications (); 
		//Debug.Log("clear :");
	}


}
#endif
