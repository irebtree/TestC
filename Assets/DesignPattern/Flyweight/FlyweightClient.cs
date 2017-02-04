using UnityEngine;
using System.Collections;

public class FlyweightClient : MonoBehaviour {

	// Use this for initialization
	void Start () {
		WebSiteFactory wf = new WebSiteFactory();

		WebSite wx = wf.GetWebSiteType("webSite1");
		wx.Use(new WebSiteUser("u1"));

		WebSite wy = wf.GetWebSiteType("webSite1");
		wy.Use(new WebSiteUser("u2"));

		WebSite wa = wf.GetWebSiteType("webSite2");
		wa.Use(new WebSiteUser("u3"));

		WebSite wb = wf.GetWebSiteType("webSite2");
		wb.Use(new WebSiteUser("u4"));

		Debug.Log("webSite count " + wf.GetWebSiteCount());
	}
	

}
