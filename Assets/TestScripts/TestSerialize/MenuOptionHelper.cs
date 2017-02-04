using UnityEngine;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

public class MenuOptionHelper {
	
	private string path;
	private XmlSerializer serializer;
	
	public MenuOptionHelper() {
		//path = string.Format("{0}/Single/Options/{1}", Application.streamingAssetsPath, "MenuOption.xml");
		path = string.Format("{0}/{1}", Application.persistentDataPath, "MenuOption.xml");
		Debug.Log(path);
		//path = Application.streamingAssetsPath + "/MenuOption.xml";
		//Debug.Log(path);
		this.serializer = new XmlSerializer(typeof(MenuOption));
	}
	
	public MenuOption GetMenuOption() {
		MenuOption option = new MenuOption();
	
		if(File.Exists(path)){
			//Debug.Log("KKKKK");
			using(StreamReader reader = new StreamReader(path)){
				//Debug.Log("lllll");
				//string rl = reader.ReadToEnd();
				//Debug.Log("rl " + rl );
				//StringReader sr= new StringReader(rl);
				//option = this.serializer.Deserialize(sr) as MenuOption;
				option = this.serializer.Deserialize(reader.BaseStream) as MenuOption;
				Debug.Log("bbbbb");
			}
		}
		
//		//just for test;
		if(option.items != null) {
			foreach(MenuOptionItem t in option.items){
				Debug.Log("t " + t.MenuId);
			}
		}
		Debug.Log("****");
//	
//		foreach(MenuOptionItem m in option.items)
//		{
//			//Debug.Log("MenuId " + m.MenuId);
//		}	Debug.Log(":::");
		return option;
	}
	
	public void SaveMenuOption(MenuOption option) {
		if(option != null) {
			Debug.Log("sava ");
			using(StreamWriter writer = new StreamWriter(path, false)) {
				XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
				ns.Add("","");
				this.serializer.Serialize(writer, option, ns);
				writer.Close();
			}
		}
	}
	
	/*public void Test() {
		MenuOption option = new MenuOption();
		option.items = new List<MenuOptionItem>();
		
		MenuOptionItem item = new MenuOptionItem() {
			//MenuId = "m_sb",
			//IsChecked = false
		};
		
		option.items.Add(item);
		
		item = new MenuOptionItem() {
		//	MenuId = "m_sc",
		//	IsChecked = true
		};
		
		option.items.Add(item);
		
		GetMenuOption();
		
		SaveMenuOption(option);
		
		GetMenuOption();
		
		//		StringWriter sw = new StringWriter();
		//
		//		XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
		//		ns.Add("","");
		//		XmlSerializer serialzier = new XmlSerializer(typeof(MenuOption));
		//		serialzier.Serialize(sw, option, ns);
		//		sw.Close();
		//		
		//		Debug.Log(sw.ToString());
		//
		//		string target = sw.ToString();
		//
		//		StringReader reader = new StringReader(target);
		//
		//		MenuOption tmp = serialzier.Deserialize(reader) as MenuOption;
		//
		//		foreach(MenuOptionItem t in tmp.items){
		//			Debug.Log(t);
		//		}
	}*/
}
