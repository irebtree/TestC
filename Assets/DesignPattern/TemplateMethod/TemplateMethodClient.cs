using UnityEngine;
using System.Collections;
//模板方法:定义一个操作中的算法的骨架，而将步骤延迟到子类中。模板方法使得子类可以不改变一个算法的结构即可重定义算法的某些特定步骤。
public class TemplateMethodClient : MonoBehaviour {

	// Use this for initialization
	void Start () {
		AbstractClass tm = null;
		tm = new ConcreteClassA();
		tm.TemplateMethod();

		tm = new ConcreteClassB();
		tm.TemplateMethod();
	}
	

}
