using UnityEngine;
using System.Collections;

public class Director  {
	Builder builder;
	public Director(Builder personBuilder)
	{
		builder = personBuilder;
	}

	public Person BuilderPerson()
	{
		builder.BuildHead();
		builder.BuildBody();
		builder.BuildArm();
		builder.BuildLet();
		return builder.GetPerson();
	}

}
