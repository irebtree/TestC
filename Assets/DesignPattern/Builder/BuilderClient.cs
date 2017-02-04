using UnityEngine;
using System.Collections;

public class BuilderClient : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Director dir = new Director(new ManBuilder());
		Person man;
		man = dir.BuilderPerson();
		Debug.Log(man.head);

		Director dir1 = new Director(new WomenBuilder());
		Person woment;
		woment = dir1.BuilderPerson();
		Debug.Log(woment.head);
	}
	

}
