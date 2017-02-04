using System.Xml.Serialization;
using System.Collections.Generic;

namespace DataConfig
{
	[XmlRoot("DataConf")][System.Serializable]
	public class DataConfObject1
	{
		[XmlAttribute("Version")]
		public string version;
		
		[XmlArray("AssetBundleConf")]
		[XmlArrayItem("Bundle")]
		public List<BundleInfo> mBundleList = new List<BundleInfo>();
		
		[XmlElement("MachineConf")]
		public MachineConf mMachineConf;

	}
	
	[System.Serializable]
	public class BundleInfo
	{
		[XmlAttribute("Name")]
		public string mName;
		[XmlAttribute("Version")]
		public string mVersion;
	}
	
	//[System.Serializable]
	[XmlType(TypeName = "MachineConf")]
	public class MachineConf
	{
		[XmlAttribute("Version")]
		public string version;
		
		[XmlArray("Factory")]
		[XmlArrayItem("Workshop")]
		public List<Workshop> mWorkshopList ;
		
		[XmlArray("Templates")]
		//[XmlArrayItem("Template")]
		public List<MachineTemplate> mTamplateList ;

		[XmlArray("Machines")]
		[XmlArrayItem("Machine")]
		public List<Machine> mMachineList ;
	}
	
	[System.Serializable]
	public class Workshop
	{
		[XmlAttribute("Id")]
		public string mId;
		[XmlAttribute("Name")]
		public string mName;
		
		[XmlElement("Group")]
		public List<Group> mMachineGroupList ;
	}
	
	[System.Serializable]
	public class Group
	{
		[XmlAttribute("Id")]
		public string mId;
		[XmlAttribute("Number")]
		public string mNumber;
		[XmlAttribute("Template")]
		public string mTemplateIndex;
		
		public MachineTemplate mTemplate;
	}
	
	//[System.Serializable]
	[XmlType(TypeName = "Template")]
	public class MachineTemplate
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

		public List<Machine> mMachineList ;
		
	}

	public class MachineIndex
	{
		[XmlAttribute("Index")]
		public string mIndex;
	}
	//[System.Serializable]
	[XmlType(TypeName = "Machine")]
	public class Machine
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
		public List<MachinePart> mMachinePartList ;
	}
	//[System.Serializable]
	[XmlType(TypeName = "Item")]
	public class MachinePart
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

	}



	public class ConfDatas
	{
		public string version;

		public List<BundleInfo> mBundleList = new List<BundleInfo>();

		public MachineConf mMachineConf;
	}

	public class XmlConver
	{
		public static ConfDatas ConverToConDatas(DataConfObject1 xmlObject)
		{
			ConfDatas data = new ConfDatas();
			data.version = xmlObject.version;
			data.mBundleList = xmlObject.mBundleList;

			//xmlObject.mMachineConf.mTamplateList

			return null;
		}
	}


	public class MachineHud
	{
		[XmlAttribute("Type")]
		public string mType; 
		[XmlAttribute("Name")]
		public string mName;
		[XmlAttribute("HUDPrefab")]
		public string mHUDPrefab;
		[XmlAttribute("UIItemPrefab")]
		public string mUIItemPrefab;
		
		
		public List<HudPoint> mHudPointList ;
		
	}
	
	public class HudPoint
	{
		[XmlAttribute("Id")]
		public string mId;
		[XmlAttribute("Name")]
		public string mName;
	}
	
	public class HudItem
	{
		[XmlAttribute("Type")]
		public string mType;
		[XmlAttribute("Name")]
		public string mName;
	}

}







