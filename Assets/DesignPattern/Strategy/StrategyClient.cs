using UnityEngine;
using System.Collections;
//Strategy（策略模式）：定义一系列的算法,把它们一个个封装起来, 并且使它们可相互替换。本模式使得算法的变化可独立于使用它的客户。
public class StrategyClient : MonoBehaviour {

	// Use this for initialization
	void Start () {
		PersonContext co = new PersonContext(new CarStrategy());
		co.Execute();

		co = new PersonContext(new TrainStrategy());
		co.Execute();
	}
	

}
