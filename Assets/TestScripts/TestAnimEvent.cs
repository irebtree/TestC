using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class TestAnimEvent : MonoBehaviour {
	public Slider slider;
	Animation anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animation>();
		slider.onValueChanged.AddListener(delegate(float arg0) {OnValueChange(arg0);});
		AnimationEvent aEvent = new AnimationEvent();
		aEvent.time = 15f;
		aEvent.functionName ="EventFunction";//动画速度从正变到负时，即使没到触发的时间点，触发也会发生
		anim["Take 001"].clip.AddEvent(aEvent);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnValueChange(float f)
	{
		Debug.Log("***");
		anim["Take 001"].speed = f;
		if(f != 0)
		{
			if(!anim.isPlaying)
				anim.Play("Take 001");
		}
	}
	//事件回调需要Animation组件
	void EventFunction()
	{
		Debug.Log("time "+ anim["Take 001"].time);
		if( anim["Take 001"].speed >0f)
			Debug.Log("sisisi");
	}

}
