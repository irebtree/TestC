using UnityEngine;
using System.Collections;

public class VisitorA : Ivisitor {

	public void Visit(ElementA a)
	{
		a.OperationA();
	}
	public void Visit(ElementB b)
	{
		b.OperationB();
	}
}
