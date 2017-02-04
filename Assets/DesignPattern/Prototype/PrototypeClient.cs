using UnityEngine;
using System.Collections;
//Prototype（原型模式）：用原型实例指定创建对象的种类，并且通过拷贝这个原型来创建新的对象
public class PrototypeClient : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Prototype po = new Prototype();
		for(int i=0;i<5;i++)
		{
			Prototype clonePo = (Prototype)po.Clone();
			clonePo.Show();
		}
	}
	

}
