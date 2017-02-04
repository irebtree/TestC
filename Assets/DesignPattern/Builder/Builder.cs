using UnityEngine;
using System.Collections;

public abstract class Builder  {
	protected Person person;
	public Builder()
	{
		person = new Person();
	}

	public abstract void BuildHead();
	public abstract void BuildBody();
	public abstract void BuildArm();
	public abstract void BuildLet();

	public Person GetPerson()
	{
		return person;
	}
}
