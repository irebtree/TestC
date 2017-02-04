using UnityEngine;
using System.Collections;
using System.Xml;
public class TestXml : MonoBehaviour {
	string path ;
	// Use this for initialization
	void Start () {
		path = Application.streamingAssetsPath + "/Xml.xml";
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void TestXML()
	{
		XmlDocument doc = new XmlDocument ();
		doc.Load (path);
		//Debug.Log (doc);
		XmlNode rootNode = doc.SelectSingleNode ("/bookstore");//选取根节点bookstore，这是绝对路径写法
		//Debug.Log (rootNode.Name);

		XmlNodeList childNodes = doc.SelectNodes ("bookstore");//选取 bookstore 元素的所有子节点。
		foreach(XmlNode node in childNodes)
		{
			//Debug.Log (node.Name);
		}

		XmlNodeList theChildNodes = doc.SelectNodes ("bookstore/book");//选取所有属于 bookstore 的子元素的 book元素，这是相对路径写法。
		foreach (XmlNode node in theChildNodes) 
		{
			//Debug.Log(node.Name);
		}

		XmlNodeList theChildNodesBehi = doc.SelectNodes ("bookstore//book");//选择所有属于 bookstore 元素的后代的 book 元素，而不管它们位于 bookstore 之下的什么位置。
		foreach (XmlNode node in theChildNodesBehi) 
		{
				//Debug.Log(node.Name);
		}

		XmlNodeList Nodes = doc.SelectNodes ("//book");//选择所有 book 元素，而不管它们在文档中的位置
		foreach (XmlNode node in Nodes) 
		{
				//Debug.Log(node.Name);
		}

		XmlNodeList Nodes1 = doc.SelectNodes ("//title[@lang]");//表示选择所有具有lang属性的title节点
		foreach (XmlNode node in Nodes1) 
		{
		//	Debug.Log(node.Name);
		}

		XmlNodeList Nodes2 = doc.SelectNodes ("//title[@lang='en']");//表示选择所有lang属性的值等于"en"的title节点
		foreach (XmlNode node in Nodes2) 
		{
			//Debug.Log(node.InnerText);
		}

		XmlNodeList atiVal = doc.SelectNodes ("//book[@category]");
		foreach (XmlNode node in atiVal) 
		{
			//Debug.Log(node.Attributes["category"].Value);//选取当前节点指定属性
		}

		XmlNodeList node3 = doc.SelectNodes("//book[@category='COOKING']//title[@lang='en']");
		foreach(XmlNode node in node3)
		{
			//Debug.Log("PPP  " + node.Attributes["category"].Value);
			Debug.Log("III " + node.OuterXml );
		}

	}
}
