using System;
using UnityEngine;
using System.Collections.Generic;

using System.Xml.Serialization;

public delegate string GetArg ();

[XmlRoot("item")]
public class MenuConf
{

	private bool m_IsWebView = false;

	[XmlAttribute("id")]
	public string Id {
		get;
		set;
	}

	[XmlAttribute("name")]
	public string Name {
		get;
		set;
	}

	[XmlAttribute("icon")]
	public string Icon {
		get;
		set;
	}



	[XmlElement("xmlFileName")]
	public string XmlFileFormat {
		get;
		set;
	}

	[XmlElement("info")]
	public string Info {
		get;
		set;
	}

	[XmlElement("extraArgs"), XmlArrayItem("arg")]
	public string[] ExtraArgs {
		get;
		set;
	}

	[XmlElement("panelName")]
	public string PanelName {
		get;
		set;
	}

	[XmlElement("parserKey")]
	public string ParserKey {
		get;
		set;
	}

	[XmlElement("isWebView")]
	public bool IsWebView {
		get {
			return this.m_IsWebView;
		}
		set {
			this.m_IsWebView = value;
		}
	}

	[XmlElement("webViewUrl")]
	public string WebViewUrl {
		get;
		set;
	}

	public override string ToString ()
	{
		return string.Format ("[MenuConf: Id={0}, Name={1}, Icon={2}, Method={3}, XmlFileFormat={4}, Info={5}, ExtraArgs={6}, PanelName={7}, ParserKey={8}, IsWebView={9}, WebViewUrl={10}]", Id, Name, Icon, XmlFileFormat, Info, ExtraArgs, PanelName, ParserKey, IsWebView, WebViewUrl);
	}

	static MenuConf ()
	{

//		MenuConf device = new MenuConf() {
//			m_XmlFileFormat = "{0}_{1}.xml",
//			m_info = "SB",
//			m_RequestMethod = RequestMethod.GetXmlByFile2,
//			m_panelName = "BigPanelData",
//			m_parserKey = RealTimeDataParser.HashTableKey
//		};
//
//		menuList.Add(device);
//
//		MenuConf production = new MenuConf() {
//			m_XmlFileFormat = "{0}_{1}.xml",
//			m_info = "SC",
//			m_RequestMethod = RequestMethod.GetXmlByFile2,
//			m_panelName = "BigPanelData",
//			m_parserKey = RealTimeDataParser.HashTableKey
//		};
//
//		menuList.Add(production);
//
//		MenuConf bigPanel = new MenuConf() {
//			m_XmlFileFormat = "{2}.xml",
//			m_extraArgs = new string[1] { "MachineNumber" },
//			m_RequestMethod = RequestMethod.GetXmlByFile3,
//			m_panelName = "BigPanelData",
//			m_parserKey = BigPanelDataParser.HashTableKey
//		};
//
//		menuList.Add(bigPanel);
//
//		MenuConf test = new MenuConf () {
//			m_XmlFileFormat = "Test.xml",
//			m_RequestMethod = RequestMethod.GetXmlByFile2,
//			m_panelName = "BigPanelData",
//			m_parserKey = TestParser.HashTableKey
//		};
//		
//		menuList.Add (test);
	}
}
