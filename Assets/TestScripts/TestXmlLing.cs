using UnityEngine;
using System.Collections;
using System.Xml.Linq;
public class TestXmlLing : MonoBehaviour {
	string path ;
	// Use this for initialization
	void Start () {
		path = Application.streamingAssetsPath + "/Xml.xml";
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Test()
	{
		XElement xml = XElement.Load(path);
		string st;
		//st = xml.Element("book").Value;
		st = xml.Element("book").Attribute("category").Value;

		Debug.Log(st);
	}
}
