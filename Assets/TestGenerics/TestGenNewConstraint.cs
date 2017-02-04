using UnityEngine;
using System.Collections;

public class TestGenNewConstraint : MonoBehaviour {

	// Use this for initialization
	void Start () {
		TestMyClassNew<MyClassNew> test = new TestMyClassNew<MyClassNew>();

		Debug.Log(test.obj.mName);
	}
	

}


class MyClassNew
{
	public string mName= "MyClassNew";
	public MyClassNew()
	{

	}

}

class TestMyClassNew<T> where T: new ()
{
	public	T obj;
	public TestMyClassNew()
	{
		obj = new T();//在范型里创建一个实例必须使用new约束,与其它约束一起使用时new约束放在最后面,不允许给类型形参的构造函数传递实参,不可与值约束一起使用
	}
}

