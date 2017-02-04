using UnityEngine;
using System.Collections;

public class ManBuilder : Builder {

	public ManBuilder()
	{
		person = new Person();
	}

	public override void BuildHead ()
	{
		person.head = " man head";
		Debug.Log("build man head ");
	}

	public override void BuildBody ()
	{
		person.body = "man body ";
		Debug.Log("build man body");
	}

	public override void BuildArm ()
	{
		person.arm = "man arm ";
	}

	public override void BuildLet ()
	{
		person.let = "man let";
	}
}
