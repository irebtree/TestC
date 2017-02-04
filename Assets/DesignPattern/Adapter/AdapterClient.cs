using UnityEngine;
using System.Collections;

public class AdapterClient : MonoBehaviour {
	Tartget adapter = new Adapter();
	// Use this for initialization
	void Start () {
		adapter.Request();
	}
	

}
