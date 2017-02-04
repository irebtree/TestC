using UnityEngine;
using System.Collections;
//代理模式: 为其它对象提供一种代理以控制对这个对象的访问。
public class ProxyClient : MonoBehaviour {

	// Use this for initialization
	void Start () {
		ISubject pr =new Proxy();
		pr.Function1();
		pr.Function2();
	}
	

}
