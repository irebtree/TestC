using UnityEngine;
using System.Collections;

public class TestInverseTransformPoint : MonoBehaviour {
	public Transform cam;
	public Vector3 cameraRelative ;
	public Transform sphere;
	void Example() {

		cam = Camera.main.transform;;

		cameraRelative = cam.InverseTransformPoint(transform.position);
		sphere.position = cameraRelative;
		if (cameraRelative.z > 0)
			print("The object is in front of the camera");
		else
			print("The object is behind the camera");
	}

	void Start()
	{
		//Example();
	}

	void Update()
	{
		Example();
	}
}
