using UnityEngine;
using System.Collections;
using System.Xml.Serialization;

	[XmlRoot("root")]
	public class DeserializeObject {
		[XmlElement("item")]
	public string Item;
		[XmlElement("data")]
	public string Data;
		public override string ToString ()
		{
			return string.Format ("[DeserializeObject: Item={0}, Data={1}]", Item, Data);
		}
	public DeserializeObject(){
		Item = "item";
		Data = "data";
	}
}


