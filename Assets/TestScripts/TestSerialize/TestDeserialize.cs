using UnityEngine;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Text;
using UnityEngine.UI;
public class TestDeserialize : MonoBehaviour {

	public DeserializeObject myObj;
	public Text text = null;

	string path;
	string path1;

	// Use this for initialization
	void Start () {
	
		path = Application.persistentDataPath + "/SerializeXML.xml";
		//path = Application.dataPath + "/SerializeXML.xml";
		//path = Application.streamingAssetsPath + "/SerializeXML.xml";
	//path = res
		/*FileStream myFileStream = new FileStream (path, FileMode.Open); // ios 不支持
		myObj = (DeserializeObject)mySerialize.Deserialize (myFileStream);
		Debug.Log(myObj.Item);
		text.text = myObj.Item;*/

	}

	// Update is called once per frame
	void Update () {

	}

	 public void PaserXml()
	{
//	//	Serialize s = new 
//	//	XmlSerializer mySerialize = new XmlSerializer (typeof(DeserializeObject));
//		
//		//path = Application.streamingAssetsPath + "/SerializeXML.xml";
//
//		//path1 = Application.streamingAssetsPath + "/Serialize.xml";
//		Debug.Log("dddddd");
		using( StreamReader sr = new StreamReader(path))
		{
		//string rl = sr.ReadToEnd();
		//Debug.Log(rl);
			XmlSerializer xs = new XmlSerializer(typeof(DeserializeObject));
		
			myObj = xs.Deserialize(sr.BaseStream) as DeserializeObject;
		

		text.text = myObj.Item;
		}
//		//label.text =  myObj.Item;
////		/*XmlDocument doc = new XmlDocument();
//		doc.Load(path);
//		XmlNode node = doc.SelectSingleNode("root");
//		foreach(XmlNode n in node.ChildNodes)
//		{
//			string text = node.OuterXml;
//			StringReader reader = new StringReader(text);
//			XmlSerializer xs = new XmlSerializer(typeof(DeserializeObject));
//			 myObj =  xs.Deserialize(reader) as DeserializeObject;
//			Debug.Log(myObj.Item);
//
//		}*/
		//Debug.Log(node.InnerText);

		//Debug.Log(text);

	}

	public void Deserialize()
	{
		MenuOptionHelper m = new MenuOptionHelper();
		MenuOption mo = m.GetMenuOption();
		m.SaveMenuOption(mo);

	}
	public void Serialize()
	{
		DeserializeObject obj = new DeserializeObject();
		MenuOption mo = new MenuOption();
		using( StreamWriter sw = new StreamWriter(path,false))
		{

			XmlSerializer mySerialize = new XmlSerializer (typeof(DeserializeObject));
			XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
			mySerialize.Serialize(sw,obj,ns);

		}
	}




}
