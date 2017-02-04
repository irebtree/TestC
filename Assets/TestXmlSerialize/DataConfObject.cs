using System.Xml.Serialization;
using System.Collections.Generic;
[XmlRoot("DataConf")][System.Serializable]
public class DataConfObject
{
	[XmlAttribute("Version")]
	public string version;

	[XmlArray("AssetBundleConf")]
	[XmlArrayItem("Bundle")]
	public List<C_Bundle> mBundleList = new List<C_Bundle>();

	[XmlElement("MachineConf")]
	public C_MachineConf mMachineConf;
}

[System.Serializable]
public class C_Bundle
{
	[XmlAttribute("Name")]
	public string mName;
	[XmlAttribute("Version")]
	public string mVersion;
}

//[System.Serializable]
[XmlType(TypeName = "MachineConf")]
public class C_MachineConf
{
	[XmlAttribute("Version")]
	public string version;

	[XmlArray("Factory")]
	[XmlArrayItem("Workshop")]
	public List<C_Workshop> mWorkshopList ;

	[XmlArray("Templates")]
	//[XmlArrayItem("Template")]
	public List<C_MachineSet> mMachineSetList ;
}

[System.Serializable]
public class C_Workshop
{
	[XmlAttribute("Id")]
	public string mId;
	[XmlAttribute("Name")]
	public string mName;

	[XmlElement("Group")]
	public List<C_Group> mMachineGroupList ;
}

[System.Serializable]
public class C_Group
{
	[XmlAttribute("Id")]
	public string mId;
	[XmlAttribute("Number")]
	public string mNumber;
	[XmlAttribute("Template")]
	public string mTemplate;

	public C_MachineSet mMachineSet;
}

//[System.Serializable]
[XmlType(TypeName = "Template")]
public class C_MachineSet
{
	[XmlAttribute("Template")]
	public string mTemplate;
	[XmlAttribute("Icon")]
	public string mIcon;
	[XmlAttribute("BundleName")]
	public string mBundleName;
	[XmlAttribute("PrefabName")]
	public string mPrefabName;
	[XmlAttribute("Plus")]
	public string mPlus;
	
	[XmlArray("Machines")]
	//[XmlArrayItem("Machine")]
	public List<C_Machine> mMachineList ;
	
}
//[System.Serializable]
[XmlType(TypeName = "Machine")]
public class C_Machine
{
	[XmlAttribute("Type")]
	public string mType;
	[XmlAttribute("Name")]
	public string mName;
	[XmlAttribute("Model")]
	public string mModel;
	[XmlAttribute("Icon")]
	public string mIcon;
	[XmlAttribute("BundleName")]
	public string mBundleName;
	[XmlAttribute("PrefabName")]
	public string mPrefabName;
	
	[XmlArray("Items")]
	//[XmlArrayItem("Item", IsNullable=false)]
	public List<C_Item> mItemList ;
}
//[System.Serializable]
[XmlType(TypeName = "Item")]
public class C_Item
{
	[XmlAttribute("Id")]
	public string mId;
	[XmlAttribute("Name")]
	public string mName;
	[XmlAttribute("Model")]
	public string mModel;
	[XmlAttribute("Icon")]
	public string mIcon;
	[XmlAttribute("PrefabName")]
	public string mPrefabName;

	[XmlArray("Huds")]
	//[XmlArrayItem("Hud",IsNullable=false)]
	public List<C_HUD> mHudList ;

}
//[System.Serializable]
[XmlType(TypeName = "Hud")]
public class C_HUD
{
	[XmlAttribute("Type")]
	public string mType; 
	[XmlAttribute("Name")]
	public string mName;
	[XmlAttribute("HUDPrefab")]
	public string mHUDPrefab;
	[XmlAttribute("UIItemPrefab")]
	public string mUIItemPrefab;

	[XmlArray("HudPoints")]
	//[XmlArrayItem("HudPoint", IsNullable=false)]
	public List<C_HudPoint> mHudPointList ;

}
//[System.Serializable]
[XmlType(TypeName = "HudPoint")]
public class C_HudPoint
{
	[XmlAttribute("Id")]
	public string mId;
	[XmlAttribute("Name")]
	public string mName;
	
	[XmlElement("HudItem", IsNullable=false)]
	public List<C_HUDItem> mHudItemList { get; set; }
}

[XmlType(TypeName = "HudItem")]
public class C_HUDItem
{
	[XmlAttribute("Type")]
	public string mType;
	[XmlAttribute("Name")]
	public string mName;
}





