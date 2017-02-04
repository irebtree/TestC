using UnityEngine;
using System.Collections;

public class SimpleFactoryClient : MonoBehaviour {

	// Use this for initialization
	void Start () {
		SProduct productA = SimpleSProductFactory.CreateProduct("A");
		SProduct productB = SimpleSProductFactory.CreateProduct("B");

		productA.Opration();
		productB.Opration();
	}
	

}
