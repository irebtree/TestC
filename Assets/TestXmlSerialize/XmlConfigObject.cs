using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlType(TypeName = "config")]
public class XmlConfigObject  {

	[XmlArray("rules")]
	[XmlArrayItem("rule")]
	public List<rule> rules = new List<rule>() ;
}

[XmlType(TypeName = "rule")]
public class rule
{
	[XmlAttribute]
	public string name ;
	
	[XmlArray("params")]
	//[XmlArrayItem("item")]
	public List<paramsItem> itemLists ;
}

[XmlType(TypeName = "item")]
public class paramsItem
{
	[XmlAttribute]
	public string name ;
	[XmlAttribute]
	public string type ;
	[XmlAttribute]
	public string pattern ;
	
}






[XmlType(TypeName = "item")]
public class paramsItem0
{
	[XmlAttribute]
	public string name ;
	[XmlAttribute]
	public string type ;
	[XmlAttribute]
	public string pattern ;
	
}


[XmlType(TypeName = "item")]
public class paramsItem1
{
	[XmlAttribute]
	public string name ;
	[XmlAttribute]
	public string type ;
	[XmlAttribute]
	public string pattern ;
	
}
[XmlType(TypeName = "item")]
public class paramsItem2
{
	[XmlAttribute]
	public string name ;
	[XmlAttribute]
	public string type ;
	[XmlAttribute]
	public string pattern ;
	
}

public class paramsItem3
{
	[XmlAttribute]
	public string name ;
	[XmlAttribute]
	public string type ;
	[XmlAttribute]
	public string pattern ;
	
}

public class paramsItem4
{
	[XmlAttribute]
	public string name ;
	[XmlAttribute]
	public string type ;
	[XmlAttribute]
	public string pattern ;
	
}

public class paramsItem5
{
	[XmlAttribute]
	public string name ;
	[XmlAttribute]
	public string type ;
	[XmlAttribute]
	public string pattern ;
	
}





