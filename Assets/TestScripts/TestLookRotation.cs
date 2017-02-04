using UnityEngine;
using System.Collections;

public class TestLookRotation : MonoBehaviour {
	public Transform target;
	public Transform testObj;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 dir = target.position - transform.position;
		testObj.position = dir;
		Debug.DrawLine(transform.position,dir);
		Debug.DrawLine(transform.position,target.position);
		Debug.DrawLine(dir,target.position);
		Debug.DrawLine(Vector3.zero,dir);
		Quaternion lookRot = Quaternion.LookRotation(dir);
        transform.rotation = Quaternion.Slerp(transform.rotation,lookRot,Time.deltaTime *2f);
	}

}
