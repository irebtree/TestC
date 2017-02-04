using UnityEngine;
using System.Collections;

public class WomenBuilder : Builder {

	public WomenBuilder()
	{
		person = new Person();
	}

	public override void BuildHead ()
	{
		person.head = "woment head ";
	}
	public override void BuildBody ()
	{
		person.body = "woment body";
	}
	public override void BuildArm ()
	{
		person.arm = "woment arm";
	}
	public override void BuildLet ()
	{
		person.let = "woment let";
	}
}
