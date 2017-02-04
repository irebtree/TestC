using UnityEngine;
using System.Collections;

public class Facade {

	private SubSystemOne sOne;
	private SubSystemTwo sTwo;
	private SubSystemThree sThree;
	private SubSystemFour sFour;

	public Facade()
	{
		sOne = new SubSystemOne();
		sTwo = new SubSystemTwo();
		sThree = new SubSystemThree();
		sFour = new SubSystemFour();
	}

	public void MethodA()
	{
		sOne.MethodOne();
		sTwo.MethodTwo();
		sFour.MethodFour();
	}

	public void MethodB()
	{
		sTwo.MethodTwo();
		sThree.MethodThree();
	}
}
