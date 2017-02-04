using UnityEngine;
using System.Collections;

public class TestNGUIToggleOnChange : MonoBehaviour {

	// Use this for initialization
	void Start () {
		UIToggle uiToggle = GetComponent<UIToggle>();
		EventDelegate.Add(uiToggle.onChange,OnChange);
	}
	

	void OnChange () {
		bool check = UIToggle.current.value;
		if(check)
		{
			Debug.Log(UIToggle.current.name);
		}
	}
}
