using UnityEngine;
using System.Collections;

public class DCompositeClient : MonoBehaviour {

	// Use this for initialization
	void Start () {
		DComponent root = new DComposite("root");
		root.Add(new DLeaf("leaf1"));
		root.Add(new DLeaf("leaf2"));

		DComponent branch1 = new DComposite("branch1");
		root.Add(branch1);
		branch1.Add(new DLeaf("leaf in branch1"));
		branch1.Add(new DComposite("branch2 in branch1"));

		root.Display(0);

	}
	

}
