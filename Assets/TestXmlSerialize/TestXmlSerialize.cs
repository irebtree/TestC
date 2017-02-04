using UnityEngine;
using System.Collections;
using System;
public class TestXmlSerialize : MonoBehaviour {
	public XmlConfigObject data;

	public DataConfObject data1;

	public DataConfig.DataConfObject1 data2;

	string path;
	string path1;
	string path2;
	// Use this for initialization
	void Start () {
		path = Application.streamingAssetsPath + "/" + "default.xml";
		path1 = Application.streamingAssetsPath + "/" + "DataConf.xml";
		path2 = Application.streamingAssetsPath + "/" + "DataConf1.xml";
		//data = DeserializeFromXml<XmlConfigObject> (path);
		//Debug.Log(data.rules[0].name);

		//data1 = DeserializeFromXml<DataConfObject> (path1);
		//Debug.Log(data1.mMachineConf.mMachineSetList[0].mMachineList[2].mItemList[0].mHudList[0].mHudPointList[0].mHudItemList.Count);
	}

	public void Data()
	{
		data = DeserializeFromXml<XmlConfigObject> (path);
		Debug.Log("++3 " + data.rules[0].itemLists.Count);
	}

	public void Data1()
	{
		data1 = DeserializeFromXml<DataConfObject> (path1);
		Debug.Log(data1.mMachineConf.mMachineSetList[0].mMachineList[2].mItemList[0].mHudList[0].mHudPointList[0].mHudItemList.Count);
		//Debug.Log(data1.mMachineConf.mMachineSetList[0].mMachineList[2].mItemList.Count);
	}

	public void Data2()
	{
		data2 = DeserializeFromXml<DataConfig.DataConfObject1>(path2);
		//Debug.Log("data 2 >>... " + data2.mMachineConf.mMachineList[2].mMachinePartList[0].mHudList[0].mHudPointList.Count);
	}

	// Update is called once per frame
	void Update () {
	
	}


	public static T DeserializeFromXml<T>(string filePath)
	{
		try
		{
			if (!System.IO.File.Exists(filePath))
				throw new ArgumentNullException(filePath + " not Exists");
			
			using (System.IO.StreamReader reader = new System.IO.StreamReader(filePath))
			{
				System.Xml.Serialization.XmlSerializer xs = new System.Xml.Serialization.XmlSerializer(typeof(T));
				T ret = (T)xs.Deserialize(reader);
				return ret;
			}
		}
		catch (Exception ex)
		{
			return default(T);
		}
	}

}
