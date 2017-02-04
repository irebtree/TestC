using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public abstract class Subject  {

	List<Observer> obsList = new List<Observer> ();

	public void AddObserver(Observer obs)
	{
		obsList.Add(obs);
	}

	public void DelObserver(Observer obs)
	{
		obsList.Remove(obs);
	}

	public void NotifiObservers()
	{
		foreach(var obs in obsList)
		{
			obs.Update();
		}
	}



}
